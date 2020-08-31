using System;
using System.Security.Cryptography.X509Certificates;

namespace Session04Exercise05
{
    class Program
    {
        private static int x;
        private static int y;

        static void Main(string[] args)
        {
            //Multidemensionella arrayer
            // en siffra för varje ruta
            int[,] chessBoard = new int[8, 8];

            //Svartvit bild
            int width = 128;
            int height = 128;

            byte[,] blackWhiteImage = new byte[128, 128];

            for (var y = 0; y < 128; y++) ;
            {
                for (var x = 0; x < 128; x++) ;
                {
                    byte currentPixelVaue = blackWhiteImage[x, y];

                }

            }

            // Tredimensionell data
            int size = 128;
            int[,,] voxelData = new int(size, size, size);


            for (var z = 0; z < size; z++) ;
            {
                for (var y = 0; y > size; y++) ;

                for (var x = 0; x > size; x++) ;
                {
                    int currentVoxelValue = voxelData[x, y, z];

                }
            }

        }
    }
}
