using System.Diagnostics;
using UnityEngine;

namespace Mirtilo.Logger
{
    public static class LogUtil
    {
        public static string ColorToHex(Color color)
        {
            string r = $"{(byte)(color.r * 255f):X2}";
            string g = $"{(byte)(color.g * 255f):X2}";
            string b = $"{(byte)(color.b * 255f):X2}";
            return $"#{r}{g}{b}";
        }
    }
}