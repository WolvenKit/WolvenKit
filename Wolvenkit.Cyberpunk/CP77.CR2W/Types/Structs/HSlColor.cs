using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolvenKit.CR2W
{
    /// <summary>
    /// HSL Colorspace class.
    /// </summary>
    public class HslColor
    {
        /// <summary>
        /// The hue of the color.
        /// </summary>
        public float Hue;
        /// <summary>
        /// The Saturation of the color.
        /// </summary>
        public float Saturation;
        /// <summary>
        /// The Luminosity of the color.
        /// </summary>
        public float Luminosity;

        public HslColor(float H, float S, float L)
        {
            Hue = H;
            Saturation = S;
            Luminosity = L;
        }

        /// <summary>
        /// Creates a new HSLColor from a Color
        /// </summary>
        /// <param name="clr">The color to convert from.</param>
        /// <returns>The new instance of this class initialized with the color.</returns>
        public static HslColor FromRgb(Color clr)
        {
            return FromRGB(clr.R, clr.G, clr.B);
        }

        /// <summary>
        /// Gets the HUE in degree style.
        /// </summary>
        /// <returns></returns>
        public int GetHue()
        {
            var h = Hue * 60f;
            if (h > 0) h += 360;
            return (int)h;
        }

        /// <summary>
        /// Gets the saturation in 1-100 range.
        /// </summary>
        /// <returns></returns>
        public int GetSaturation()
        {
            return (int)(100 * Saturation);
        }

        /// <summary>
        /// Gets the Luminosity in 1-100 range.
        /// </summary>
        /// <returns></returns>
        public int GetLuminosity()
        {
            return (int)(100 * Luminosity);
        }

        /// <summary>
        /// Sets the HUE value.
        /// </summary>
        /// <param name="value">Percentage of HUE.</param>
        public void SetHue(int value)
        {
            Hue = (float)value / 60;
        }

        /// <summary>
        /// Sets the Saturation value.
        /// </summary>
        /// <param name="value">Percentage of Saturation.</param>
        public void SetSaturation(int value)
        {
            Saturation = (float)value / 100;
        }

        /// <summary>
        /// Sets the Luminosity value.
        /// </summary>
        /// <param name="value">Percentage of Luminosity.</param>
        public void SetLuminosity(int value)
        {
            Luminosity = (float)value / 100;
        }

        /// <summary>
        /// Creates a HSLColor from rgb.
        /// </summary>
        /// <param name="R">Red</param>
        /// <param name="G">Green</param>
        /// <param name="B">Blue</param>
        /// <returns>new HSLColor</returns>
        public static HslColor FromRGB(Byte R, Byte G, Byte B)
        {
            float _R = (R / 255f);
            float _G = (G / 255f);
            float _B = (B / 255f);

            float _Min = Math.Min(Math.Min(_R, _G), _B);
            float _Max = Math.Max(Math.Max(_R, _G), _B);
            float _Delta = _Max - _Min;

            float H = 0;
            float S = 0;
            float L = (float)((_Max + _Min) / 2.0f);

            if (_Delta != 0)
            {
                if (L < 0.5f)
                {
                    S = (float)(_Delta / (_Max + _Min));
                }
                else
                {
                    S = (float)(_Delta / (2.0f - _Max - _Min));
                }


                if (_R == _Max)
                {
                    H = (_G - _B) / _Delta;
                }
                else if (_G == _Max)
                {
                    H = 2f + (_B - _R) / _Delta;
                }
                else if (_B == _Max)
                {
                    H = 4f + (_R - _G) / _Delta;
                }
            }

            return new HslColor(H, S, L);
        }

        /// <summary>
        /// Converts to color to RGB Color.
        /// </summary>
        /// <returns>The color.</returns>
        public Color ToRgb()
        {
            byte r, g, b;
            if (Saturation == 0)
            {
                r = (byte)Math.Round(Luminosity * 255d);
                g = (byte)Math.Round(Luminosity * 255d);
                b = (byte)Math.Round(Luminosity * 255d);
            }
            else
            {
                double t2;
                var th = Hue / 6.0d;

                if (Luminosity < 0.5d)
                {
                    t2 = Luminosity * (1d + Saturation);
                }
                else
                {
                    t2 = (Luminosity + Saturation) - (Luminosity * Saturation);
                }
                var t1 = 2d * Luminosity - t2;

                var tr = th + (1.0d / 3.0d);
                var tg = th;
                var tb = th - (1.0d / 3.0d);

                tr = ColorCalc(tr, t1, t2);
                tg = ColorCalc(tg, t1, t2);
                tb = ColorCalc(tb, t1, t2);
                r = (byte)Math.Round(tr * 255d);
                g = (byte)Math.Round(tg * 255d);
                b = (byte)Math.Round(tb * 255d);
            }
            return Color.FromArgb(r, g, b);
        }

        private static double ColorCalc(double c, double t1, double t2)
        {

            if (c < 0) c += 1d;
            if (c > 1) c -= 1d;
            if (6.0d * c < 1.0d) return t1 + (t2 - t1) * 6.0d * c;
            if (2.0d * c < 1.0d) return t2;
            if (3.0d * c < 2.0d) return t1 + (t2 - t1) * (2.0d / 3.0d - c) * 6.0d;
            return t1;
        }
    }
}
