using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace WindowsDesktopIconVisibilityToggler
{
    class RightClickMenu
    {
		public ContextMenuStrip Create()
		{
			// Add the default menu options.
			ContextMenuStrip menu = new ContextMenuStrip();
			ToolStripMenuItem item;
			ToolStripSeparator separator;
			item = new ToolStripMenuItem();
			item.Text = Resources.infoText;
			item.Image = Resources.infoIcon;
			menu.Items.Add(item);

			// Separator.
			separator = new ToolStripSeparator();
			menu.Items.Add(separator);

			// Exit.
			item = new ToolStripMenuItem();
			item.Text = "Exit";
			item.Click += new System.EventHandler(QuitApplication);
			item.Image = Resources.closeIcon;
			menu.Items.Add(item);

			return menu;
		}
		void QuitApplication(object sender, EventArgs e)
		{
			// Quit without further ado.
			Application.Exit();
		}
	}
}
