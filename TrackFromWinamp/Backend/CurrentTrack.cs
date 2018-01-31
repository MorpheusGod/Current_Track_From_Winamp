using System;
using System.Runtime.InteropServices;

namespace TrackFromWinamp.Backend
{
    public class CurrentTrack
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int GetWindowText(IntPtr hwnd, string lpString, int cch);

        const string lpClassName = "Winamp v1.x";
        const string strTtlEnd = " - Winamp";

        public string GetSongTitle()
        {
            IntPtr hwnd = FindWindow(lpClassName, null);
            if (hwnd.Equals(IntPtr.Zero)) return "Not Running.....";

            string lpText = new string((char)0, 100);
            int intLength = GetWindowText(hwnd, lpText, lpText.Length);

            if ((intLength <= 0) || (intLength > lpText.Length)) return "Unknown";

            string strTitle = lpText.Substring(0, intLength);
            int intName = strTitle.IndexOf(strTtlEnd);
            int intLeft = strTitle.IndexOf("[");
            int intRight = strTitle.IndexOf("]");

            if ((intName >= 0) && (intLeft >= 0) && (intName < intLeft) &&
                (intRight >= 0) && (intLeft + 1 < intRight))
                return strTitle.Substring(intLeft + 1, intRight - intLeft - 1);

            if ((strTitle.EndsWith(strTtlEnd)) && (strTitle.Length > strTtlEnd.Length))
                strTitle = strTitle.Substring(0, strTitle.Length - strTtlEnd.Length);

            int intDot = strTitle.IndexOf(".");
            if ((intDot > 0) && IsNumeric(strTitle.Substring(0, intDot)))
                strTitle = strTitle.Remove(0, intDot + 1);

            return strTitle;
        }

        private bool IsNumeric(string Value)
        {
            try
            {
                double.Parse(Value);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
