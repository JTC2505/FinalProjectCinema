using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cine_FinalProject
{
    public class Datos
    {
        private static string user = "user";
        private static string password = "pass";
        public static int[,] jojo { get; set; } = new int[6, 3] { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
        public static int[,] outh { get; set; } = new int[6, 3] { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
        public static int[,] joker { get; set; } = new int[6, 3] { { 0, 1, 0 }, { 0, 1, 0 }, { 0, 1, 0 }, { 0, 1, 0 }, { 0, 1, 0 }, { 0, 1, 0 } };
        public static int[,] mil { get; set; } = new int[6, 3] { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
        public static int[,] dinamic { get; set; } = new int[6, 3] { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };

        public static string User
        {
            get { return user; }
            set { user = value; }
        }
        public static string Password
        {
            get { return password; }
            set { password = value; }
        }
        public static void limpiarDinamic() {
            for (int i = 0; i <= 5; i++)
            {
                for (int j = 0; j <= 2; j++)
                {
                    dinamic[i, j] = 0;
                }
            }
        }
    }
}
