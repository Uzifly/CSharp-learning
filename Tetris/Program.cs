namespace Tetris;
class Program
{
    static void RenderField(int[,] body)
    {         
        System.Console.Clear();
        for (int i = 0; i < body.GetLength(0); i++)
        {
            for (int j = 0; j < body.GetLength(1); j++)
            {
                System.Console.Write(body[i,j]);
            }
            System.Console.WriteLine();
        }
    }

    static int GetFigure(int type)
    {
        //переписать в массив двумерный
        int figure = 1;
        return figure;
    }
    static void Main(string[] args)
    {
        //startGame
        int tiks = Environment.TickCount;

        int[,] body = new int[20,16];
        for (int i = 0; i < body.GetLength(0); i++)
        {
            for (int j = 0; j < body.GetLength(1); j++)
            {
                body[i,j] = 0;
            }
            System.Console.WriteLine();
        }

        bool move = false;
        while(true)
        {
            if (Environment.TickCount > tiks + 500)
            {
                if(move==false){
                    body[0,7] += GetFigure(0); // проверить пересечение
                    move = true;
                }
                body
                body[19,7] += 1;
                RenderField(body);
                tiks = Environment.TickCount;
            }
        }
        //System.Console.WriteLine(String.Join(item));
    }
}
