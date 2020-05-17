using System.Text;

namespace Argos_Core.Common
{
    public static class Helper
    {
        public static string ByteArrayToString(this byte[] bytes) 
        {
            StringBuilder hex = new StringBuilder(bytes.Length * 2);
            foreach (byte x in bytes) hex.AppendFormat("{0:x2}", x);

            return hex.ToString();
        }
    }
}


