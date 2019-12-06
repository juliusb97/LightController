namespace LightController
{
	partial class Form1
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.socket1ONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.socket1OFFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.socket2ONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.socket2OFFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.socket3ONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.socket3OFFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.socket4ONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.socket4OFFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// notifyIcon1
			// 
			this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.notifyIcon1.BalloonTipText = "This is a tasktray app";
			this.notifyIcon1.BalloonTipTitle = "This is the title";
			this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
			this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
			this.notifyIcon1.Text = "notifyIcon1";
			this.notifyIcon1.Visible = true;
			this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.socket1ONToolStripMenuItem,
            this.socket1OFFToolStripMenuItem,
            this.socket2ONToolStripMenuItem,
            this.socket2OFFToolStripMenuItem,
            this.socket3ONToolStripMenuItem,
            this.socket3OFFToolStripMenuItem,
            this.socket4ONToolStripMenuItem,
            this.socket4OFFToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(143, 180);
			// 
			// socket1ONToolStripMenuItem
			// 
			this.socket1ONToolStripMenuItem.Name = "socket1ONToolStripMenuItem";
			this.socket1ONToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
			this.socket1ONToolStripMenuItem.Text = "Socket 1 ON";
			// 
			// socket1OFFToolStripMenuItem
			// 
			this.socket1OFFToolStripMenuItem.Name = "socket1OFFToolStripMenuItem";
			this.socket1OFFToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
			this.socket1OFFToolStripMenuItem.Text = "Socket 1 OFF";
			// 
			// socket2ONToolStripMenuItem
			// 
			this.socket2ONToolStripMenuItem.Name = "socket2ONToolStripMenuItem";
			this.socket2ONToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
			this.socket2ONToolStripMenuItem.Text = "Socket 2 ON";
			// 
			// socket2OFFToolStripMenuItem
			// 
			this.socket2OFFToolStripMenuItem.Name = "socket2OFFToolStripMenuItem";
			this.socket2OFFToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
			this.socket2OFFToolStripMenuItem.Text = "Socket 2 OFF";
			// 
			// socket3ONToolStripMenuItem
			// 
			this.socket3ONToolStripMenuItem.Name = "socket3ONToolStripMenuItem";
			this.socket3ONToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
			this.socket3ONToolStripMenuItem.Text = "Socket 3 ON";
			// 
			// socket3OFFToolStripMenuItem
			// 
			this.socket3OFFToolStripMenuItem.Name = "socket3OFFToolStripMenuItem";
			this.socket3OFFToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
			this.socket3OFFToolStripMenuItem.Text = "Socket 3 OFF";
			// 
			// socket4ONToolStripMenuItem
			// 
			this.socket4ONToolStripMenuItem.Name = "socket4ONToolStripMenuItem";
			this.socket4ONToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
			this.socket4ONToolStripMenuItem.Text = "Socket 4 ON";
			// 
			// socket4OFFToolStripMenuItem
			// 
			this.socket4OFFToolStripMenuItem.Name = "socket4OFFToolStripMenuItem";
			this.socket4OFFToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
			this.socket4OFFToolStripMenuItem.Text = "Socket 4 OFF";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Name = "Form1";
			this.Text = "Form1";
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		private System.Windows.Forms.NotifyIcon notifyIcon1;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem socket1ONToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem socket1OFFToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem socket2ONToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem socket2OFFToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem socket3ONToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem socket3OFFToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem socket4ONToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem socket4OFFToolStripMenuItem;
	}
}

