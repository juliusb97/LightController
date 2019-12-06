using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;

namespace LightController
{
	class SystemTrayApplication : ApplicationContext
	{
		private NotifyIcon	trayIcon;
		private ContextMenu socketOverview;

		public SystemTrayApplication()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));

			socketOverview = new ContextMenu();
			socketOverview.MenuItems.Add(new MenuItem("Socket 1 ON",	(sender, args) => ControlSocket(0, 1)));
			socketOverview.MenuItems.Add(new MenuItem("Socket 1 OFF",	(sender, args) => ControlSocket(0, 0)));
			socketOverview.MenuItems.Add(new MenuItem("Socket 2 ON",	(sender, args) => ControlSocket(1, 1)));
			socketOverview.MenuItems.Add(new MenuItem("Socket 2 OFF",	(sender, args) => ControlSocket(1, 0)));
			socketOverview.MenuItems.Add(new MenuItem("Socket 3 ON",	(sender, args) => ControlSocket(2, 1)));
			socketOverview.MenuItems.Add(new MenuItem("Socket 3 OFF",	(sender, args) => ControlSocket(2, 0)));
			socketOverview.MenuItems.Add(new MenuItem("Socket 4 ON",	(sender, args) => ControlSocket(3, 1)));
			socketOverview.MenuItems.Add(new MenuItem("Socket 4 OFF",	(sender, args) => ControlSocket(3, 0)));
			socketOverview.MenuItems.Add(new MenuItem("-"));
			socketOverview.MenuItems.Add(new MenuItem("All ON",			(sender, args) => ControlSocket(-1, 1)));
			socketOverview.MenuItems.Add(new MenuItem("All OFF",		(sender, args) => ControlSocket(-1, 0)));
			socketOverview.MenuItems.Add(new MenuItem("-"));
			socketOverview.MenuItems.Add(new MenuItem("Exit",			(sender, args) => Exit(sender, args)));

			trayIcon = new NotifyIcon()
			{
				Visible = true,
				Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon"))),
				ContextMenu = socketOverview
			};
		}

		static async Task SendRequest(int socketNo, int IO)
		{
			if (socketNo == -1)
			{
				using (var client = new HttpClient())
				{
					var msg = new HttpRequestMessage(HttpMethod.Get, "http://raspberrypi:6969/?action=" + ((IO == 1) ? "turnon" : "turnoff"));
					await client.SendAsync(msg);
				}
			}
			else
			{
				using (var client = new HttpClient())
				{
					var msg = new HttpRequestMessage(HttpMethod.Get, "http://raspberrypi:6969/?action=" + ((IO == 1) ? "on" : "off") + "&no=" + socketNo);
					await client.SendAsync(msg);
				}
			}
		}

		//[System.Runtime.InteropServices.ComVisible(true)]
		//[System.Serializable]
		void ControlSocket(int socketNo, int IO)
		{
			Task task = SendRequest(socketNo, IO);
			task.Wait();
		}

		void Exit(object Sender, EventArgs e)
		{
			trayIcon.Visible = false;
			Application.Exit();
		}

	}
}
