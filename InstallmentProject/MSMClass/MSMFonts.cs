using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MSMClass
{
    public static class FontManager
    {
        // Fields
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static FontFamily k__BackingField;
        public static PrivateFontCollection FontCollection = new PrivateFontCollection();

        // Methods
        static FontManager()
        {
            if (AddFontFromResource(MSMClass.Properties.Resources.BNAZANIN))
            {
                BNazanin = FontCollection.Families[0];
            }
        }

        private static bool AddFontFromResource(byte[] fontArray)
        {
            try
            {
                int length = fontArray.Length;
                IntPtr destination = Marshal.AllocCoTaskMem(length);
                Marshal.Copy(fontArray, 0, destination, length);
                uint pcFonts = 0;
                AddFontMemResourceEx(destination, (uint)fontArray.Length, IntPtr.Zero, ref pcFonts);
                FontCollection.AddMemoryFont(destination, length);
                Marshal.FreeCoTaskMem(destination);
                return true;
            }
            catch
            {
                return false;
            }
        }

        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont, IntPtr pdv, [In] ref uint pcFonts);
        public static Font GetFont(string fontfamily, float size, FontStyle style)
        {
            if (fontfamily.ToLower() == "bnazanin")
            {
                return new Font(BNazanin, size, style);
            }
            return new Font(fontfamily, size, style);
        }

        // Properties
        public static FontFamily BNazanin
        {
            [CompilerGenerated]
            get
            {
            return  k__BackingField;
            }
        [CompilerGenerated]
            set
            {
             k__BackingField = value;
            }
        }
    }


}
