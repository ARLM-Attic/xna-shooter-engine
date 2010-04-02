using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace InputMappingEditor
{
    public static class Win32Api
    {
        [DllImport("uxtheme", CharSet = CharSet.Unicode)]
        public extern static Int32 SetWindowTheme
                (IntPtr hWnd, String textSubAppName, String textSubIdList);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SendMessage
                    (IntPtr hWnd, int msg, int wParam, int lParam);

        public static void ApplyEffectsToListView(ListView lv)
        {
            // Apply Aero effect
            SetWindowTheme(lv.Handle, "explorer", null);

            // Enable enhanced effects
            SendMessage(lv.Handle, 0x1000 + 54, 0x00010000, 0x00010000);
        }

        public static void ApplyEffectsToTreeView(TreeView tv)
        {
            // Apply Aero effect
            SetWindowTheme(tv.Handle, "explorer", null);

            // Remove lines, in keeping with Explorer effect
            tv.ShowLines = false;

            // Send TVS_EX_FADEINOUTEXPANDOS [0x0040] message to
            // the TreeView, enabling fade in/out on the TreeView
            SendMessage(tv.Handle, 0x1100 + 44, 0x0040, 0x0040);

            // Send TVS_EX_AUTOHSCROLL [0x0020] message to the TreeView
            // so that it auto-scrolls, explorer-style.
            SendMessage(tv.Handle, 0x1100 + 44, 0x0020, 0x0020);
        }

    }
}
