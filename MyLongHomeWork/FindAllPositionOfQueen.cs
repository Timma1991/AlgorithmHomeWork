namespace MyLongHomeWork
{
    class FindAllPositionOfQueen
    {
        int counter = 0;
        Dictionary<string, int[,]> results = new Dictionary<string, int[,]>();
        int[,] board = new int[8, 8];

        public void Run()
        {

        }

        public void PrintBoard()
        {

            Console.WriteLine("=====================================================#" + counter++);
            for (int i = 0; i < 8; ++i)
            {
                for (int j = 0; j < 8; ++j)
                {
                    if (board[i, j] == 1)
                        Console.Write(" Q ");
                    else
                        Console.Write(" + ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("=====================================================");

        }


        public void TryQueen(int i)
        {
            for (int j = 0; j < 8; j++)
            {
                if (!IsBeaten(board, i, j))
                {
                    board[i, j] = 1;
                    if (i == 7)
                    {
                        PrintBoard();
                        board[i, j] = 0;
                        return;
                    }
                    else
                    {
                        TryQueen(i + 1);
                        board[i, j] = 0;
                    }
                }
            }

            return;
        }


        

        /// <summary>
        /// Проверяем бьется ли позиция другими ферзями
        /// </summary>
        /// <returns>true если бьется</returns>
        private bool IsBeaten(int[,] field, int x, int y)
        {
            return CheckHorizontal(field, y) || CheckVertical(field, x) || CheckDiagonal(field, x, y);
        }

        /// <summary>
        /// Проверяем бьется ли клетка по горизонтали
        /// </summary>
        private bool CheckHorizontal(int[,] field, int y)
        {
            for (int i = 0; i < field.GetLength(1); i++)
            {
                if (field[i, y] == 1)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Проверяем бьется ли клетка по вертикали
        /// </summary>
        private bool CheckVertical(int[,] field, int x)
        {
            for (int i = 0; i < field.GetLength(0); i++)
            {
                if (field[x, i] == 1)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Проверяем бьется ли клетка по диагонали
        /// </summary>
        private bool CheckDiagonal(int[,] field, int x, int y)
        {
            //Проверяем наличие других ферзей по диагоналям
            return
                CheckDiagonalDirection(field, x, y, -1, -1) || // налево-наверх
                CheckDiagonalDirection(field, x, y, -1, 1) || // налево-вниз
                CheckDiagonalDirection(field, x, y, 1, -1) || // направо-наверх
                CheckDiagonalDirection(field, x, y, 1, 1); // налево-вниз
        }

        /// <summary>
        /// Проверяем бьется ли клетка в указанном направлении
        /// </summary>
        /// <param name="field">поле</param>
        /// <param name="x">Позиция клетки по X (или номер столбца)</param>
        /// <param name="y">Позиция клетки по Y (или номер строки)</param>
        /// <param name="moveX">Направление движения по X (или по столбцам) -1 => налево; +1 => направо</param>
        /// <param name="moveY">Направление движения по Y (или по строкам) -1 => наверх; +1 => вниз</param>
        /// <returns></returns>
        private bool CheckDiagonalDirection(int[,] field, int x, int y, int moveX, int moveY)
        {
            int tempX = x;
            int tempY = y;
            while (tempX > 0 && tempX < field.GetLength(1) - 1 && tempY > 0 && tempY < field.GetLength(0) - 1)
            {
                tempX += moveX;
                tempY += moveY;
                if (field[tempX, tempY] == 1)
                {
                    return true;
                }
            }
            return false;
        }

    }


}
