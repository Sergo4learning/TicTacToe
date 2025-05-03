namespace TicTacToe
{
    using System;
    using System.Drawing;

    internal class Program
    {
        static void Main(string[] args)
        {
            void draw_fild(char[,] fild_1)
            {
                Console.ResetColor();
                double temp;
                double temp2;
                for (int i = 0; i < 13; i++)
                {
                    for (int j = 0; j < 12; j++)
                    {
                        if ((j % 4 == 2) & (i % 4 == 2))
                        {
                            if (fild_1[i, j] != 'Х' & fild_1[i, j] != 'O')
                            {
                                temp = j * 1.0 / 4;
                                temp2 = i * 1.0 / 4;
                                string temp3 = Convert.ToString((Math.Round(temp, MidpointRounding.ToPositiveInfinity) + (3 - Math.Round(temp2, MidpointRounding.ToPositiveInfinity)) * 3));
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.Write(Convert.ToChar(temp3));
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.Write(fild_1[i, j]);
                            }
                        }
                        else
                        {
                            Console.Write(fild_1[i, j]);
                        }
                    }
                    Console.WriteLine(fild_1[i, 12]);
                }
            }
            void draw_winner(char[,] fild_1, int winline)
            {
                for (int i = 0; i < 13; i++)
                {
                    for (int j = 0; j < 12; j++)
                    {
                        switch (winline)
                        {
                            case 1 or 2 or 3:
                                if (2 + (winline - 1) * 4 == i)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Write(fild_1[i, j]);
                                    Console.ResetColor();
                                }
                                else
                                {
                                    Console.Write(fild_1[i, j]);
                                }
                                ;
                                break;
                            case 4 or 5 or 6:
                                if (2 + (winline - 4) * 4 == j)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Write(fild_1[i, j]);
                                    Console.ResetColor();
                                }
                                else
                                {
                                    Console.Write(fild_1[i, j]);
                                }
                                ;
                                break;
                            case 7:
                                if ((j == i) & (i > 1) & (i < 11))
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Write(fild_1[i, j]);
                                    Console.ResetColor();
                                }
                                else
                                {
                                    Console.Write(fild_1[i, j]);
                                }
                                break;
                            case 8:
                                if ((12 - j == i) & (i > 1) & (i < 11))
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Write(fild_1[i, j]);
                                    Console.ResetColor();
                                }
                                else
                                {
                                    Console.Write(fild_1[i, j]);
                                }
                                break;
                        }
                    }
                    Console.WriteLine(fild_1[i, 12]);
                }
            }
            bool move(ref char[,] fild_1, char Х_O, ref int wm)
            {
                Console.Write(Х_O + " - ваш ход (нажмите на дополнительной клавиатуре кнопку с цыфрой куда хотите поставить " + Х_O + "):");
                ConsoleKeyInfo move_1/*, move_2*/;
                move_1 = Console.ReadKey();
                switch (move_1.Key.ToString())
                {
                    case "D7" or "NumPad7":
                        if (fild_1[2, 2] == ' ')
                        {
                            fild_1[2, 2] = Х_O;
                            return false;
                        }
                        else
                        {
                            Console.WriteLine("Куды прёж, не видишь, занято? Давай Ладом");
                            return true;
                        }
                    case "D8" or "NumPad8":
                        if (fild_1[2, 6] == ' ')
                        {
                            fild_1[2, 6] = Х_O;
                            return false;
                        }
                        else
                        {
                            Console.WriteLine("Куды прёж, не видишь, занято? Давай Ладом");
                            return true;
                        }
                    case "D9" or "NumPad9":
                        if (fild_1[2, 10] == ' ')
                        {
                            fild_1[2, 10] = Х_O;
                            return false;
                        }
                        else
                        {
                            Console.WriteLine("Куды прёж, не видишь, занято? Давай Ладом");
                            return true;
                        }
                    case "D4" or "NumPad4":
                        if (fild_1[6, 2] == ' ')
                        {
                            fild_1[6, 2] = Х_O;
                            return false;
                        }
                        else
                        {
                            Console.WriteLine("Куды прёж, не видишь, занято? Давай Ладом");
                            return true;
                        }
                    case "D5" or "NumPad5":
                        if (fild_1[6, 6] == ' ')
                        {
                            fild_1[6, 6] = Х_O;
                            return false;
                        }
                        else
                        {
                            Console.WriteLine("Куды прёж, не видишь, занято? Давай Ладом");
                            return true;
                        }
                    case "D6" or "NumPad6":
                        if (fild_1[6, 10] == ' ')
                        {
                            fild_1[6, 10] = Х_O;
                            return false;
                        }
                        else
                        {
                            Console.WriteLine("Куды прёж, не видишь, занято? Давай Ладом");
                            return true;
                        }
                    case "D1" or "NumPad1":
                        if (fild_1[10, 2] == ' ')
                        {
                            fild_1[10, 2] = Х_O;
                            return false;
                        }
                        else
                        {
                            Console.WriteLine("Куды прёж, не видишь, занято? Давай Ладом");
                            return true;
                        }
                    case "D2" or "NumPad2":
                        if (fild_1[10, 6] == ' ')
                        {
                            fild_1[10, 6] = Х_O;
                            return false;
                        }
                        else
                        {
                            Console.WriteLine("Куды прёж, не видишь, занято? Давай Ладом");
                            return true;
                        }
                    case "D3" or "NumPad3":
                        if (fild_1[10, 10] == ' ')
                        {
                            fild_1[10, 10] = Х_O;
                            return false;
                        }
                        else
                        {
                            Console.WriteLine("Куды прёж, не видишь, занято? Давай Ладом");
                            return true;
                        }
                    default:
                        Console.WriteLine("Неверный ход, ты в крестики нолики то играть умеешь? Давай Ладом");
                        wm++;
                        if (wm > 4)
                        {
                            Console.WriteLine("Ну ты меня достал уже, я за тебя сходил");
                            just_move(ref fild_1, Х_O);
                            return false;
                        }
                        return true;
                }
            }
            void just_move(ref char[,] fild_1, char X_O)
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (fild_1[2 + j * 4, 2 + i * 4] == ' ')
                        {
                            fild_1[2 + j * 4, 2 + i * 4] = X_O;
                            return;
                        }
                    }
                }
            }
            bool just_play(ref char[,] fild_1, char X_O)
            {
                char X_O_enemy = ' ';
                int[] line_we = new int[9];
                int[] line_enemy = new int[9];
                if (fild_1[6, 6] == ' ')
                {
                    fild_1[6, 6] = X_O;
                    return true;
                }
                line_we = game_over(fild_1, X_O);
                if (X_O == 'O')
                {
                    X_O_enemy = 'Х';
                }
                else
                {
                    X_O_enemy = 'O';
                }
                line_enemy = game_over(fild_1, X_O_enemy);
                for (int i = 0; i < 8; i++)
                {
                    if (line_we[i] == 2)
                    {
                        if (i < 3)
                        {
                            for (int k = 0; k < 3; k++)
                            {
                                if (fild_1[2 + 4 * i, 2 + 4 * k] == ' ')
                                {
                                    fild_1[2 + 4 * i, 2 + 4 * k] = X_O;
                                    return true;
                                }
                            }
                        }
                        else if (i < 6)
                        {
                            for (int k = 0; k < 3; k++)
                            {
                                if (fild_1[2 + 4 * k, 2 + 4 * (i - 3)] == ' ')
                                {
                                    fild_1[2 + 4 * k, 2 + 4 * (i - 3)] = X_O;
                                    return true;
                                }
                            }
                        }
                        else
                        {
                            for (int k = 0; k < 3; k++)
                            {
                                if (fild_1[2 + 4 * k, 2 + 4 * k] == ' ')
                                {
                                    fild_1[2 + 4 * k, 2 + 4 * k] = X_O;
                                    return true;
                                }
                                if (fild_1[10 - 4 * k, 2 + 4 * k] == ' ')
                                {
                                    fild_1[10 - 4 * k, 2 + 4 * k] = X_O;
                                    return true;
                                }
                            }
                        }
                    }
                    if (line_enemy[i] == 2)
                    {
                        if (i < 3)
                        {
                            for (int k = 0; k < 3; k++)
                            {
                                if (fild_1[2 + 4 * i, 2 + 4 * k] == ' ')
                                {
                                    fild_1[2 + 4 * i, 2 + 4 * k] = X_O;
                                    return true;
                                }
                            }
                        }
                        else if (i < 6)
                        {
                            for (int k = 0; k < 3; k++)
                            {
                                if (fild_1[2 + 4 * k, 2 + 4 * (i - 3)] == ' ')
                                {
                                    fild_1[2 + 4 * k, 2 + 4 * (i - 3)] = X_O;
                                    return true;
                                }
                            }
                        }
                        else
                        {
                            for (int k = 0; k < 3; k++)
                            {
                                if (fild_1[2 + 4 * k, 2 + 4 * k] == ' ')
                                {
                                    fild_1[2 + 4 * k, 2 + 4 * k] = X_O;
                                    return true;
                                }
                                if (fild_1[10 - 4 * k, 2 + 4 * k] == ' ')
                                {
                                    fild_1[10 - 4 * k, 2 + 4 * k] = X_O;
                                    return true;
                                }
                            }
                        }
                    }
                }
                for (int i = 0; i < 3; i++)
                {
                    if (fild_1[2 + 4 * i, 2] == ' ')
                    {
                        fild_1[2 + 4 * i, 2] = X_O;
                        return true;
                    }
                }
                just_move(ref fild_1, X_O);
                return true;
            }
            bool is_player_human()
            {
                ConsoleKeyInfo with_who;
                bool res = true;
                Console.WriteLine("Хотите сыграть с человеком?:  Да -> 1");
                Console.WriteLine("                             Нет -> 0");
                with_who = Console.ReadKey();
                Console.WriteLine(" ");
                switch (with_who.Key.ToString())
                {
                    case "D1" or "NumPad1":
                        res = true;
                        return res;
                    case "D0" or "NumPad0":
                        res = false;
                        return res;
                    default:
                        res = true;
                        Console.WriteLine("Ну ты куда тычешь? Сам с собой поиграй вот ... расслабься");
                        return res;
                }
            }
            char play_with()
            {
                ConsoleKeyInfo who;
                char res = 'Х';
                Console.WriteLine("За кого хотите сыграть?: Х -> 1");
                Console.WriteLine("                         O -> 0");
                who = Console.ReadKey();
                Console.WriteLine(" ");
                switch (who.Key.ToString())
                {
                    case "D1" or "NumPad1":
                        res = 'Х';
                        return res;
                    case "D0" or "NumPad0":
                        res = 'O';
                        return res;
                    default:
                        res = 'Х';
                        Console.WriteLine("Ну ты чё цифры не знаешь? Ладно, будешь играть X");
                        return res;
                }
            }
            int[] game_over(char[,] fild_1, char X_O)
            {
                bool is_empty_field = false;
                int[] line = new int[9];
                for (int i = 0; i < 9; i++)
                {
                    line[i] = 0;
                }
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (fild_1[2 + i * 4, 2 + j * 4] == X_O)
                        {
                            line[i]++;
                        }
                        if (fild_1[2 + i * 4, 2 + j * 4] == ' ')
                        {
                            is_empty_field = true;
                        }
                    }
                }
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (fild_1[2 + j * 4, 2 + i * 4] == X_O)
                        {
                            line[i + 3]++;
                        }
                    }
                }
                for (int i = 0; i < 3; i++)
                {
                    if (fild_1[2 + i * 4, 2 + i * 4] == X_O)
                    {
                        line[6]++;
                    }
                    if (fild_1[10 - i * 4, 2 + i * 4] == X_O)
                    {
                        line[7]++;
                    }
                }
                for (int i = 0; i < 8; i++)
                {
                    if (line[i] == 3)
                    {
                        line[8] = i + 1;
                        return line;
                    }
                    else if (is_empty_field)
                    {
                        line[8] = 0;
                    }
                    else
                    {
                        line[8] = -1;
                    }
                }
                return line;
            }
            char[,] fild = new char[13, 13];
            for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    if (i % 4 == 0)
                    {
                        fild[i, j] = '-';
                    }
                    else if ((j % 4 == 0))
                    {
                        fild[i, j] = '|';
                    }
                    else
                    {
                        fild[i, j] = ' ';
                    }
                }
            }
            bool final = true;
            int wrong_move = 0;
            Console.ResetColor();
            bool player_1 = false;
            char playing_with = play_with();
            int end_game = 0;
            player_1 = is_player_human();
            draw_fild(fild);
            while (end_game == 0)
            {
                if (player_1)
                {
                    final = move(ref fild, playing_with, ref wrong_move);
                    draw_fild(fild);
                    end_game = game_over(fild, playing_with)[8];
                    if (final == false)
                    {
                        wrong_move = 0;
                        if (playing_with == 'O')
                        {
                            playing_with = 'Х';
                        }
                        else
                        {
                            playing_with = 'O';
                        }
                    }
                }
                else
                {
                    final = move(ref fild, playing_with, ref wrong_move);
                    draw_fild(fild);
                    end_game = game_over(fild, playing_with)[8];
                    if (final == false)
                    {
                        if (playing_with == 'O')
                        {
                            playing_with = 'Х';
                        }
                        else
                        {
                            playing_with = 'O';
                        }
                    }
                    ;
                    if (end_game == 0)
                    {
                        if (just_play(ref fild, playing_with))
                        {
                            Console.WriteLine("Компьютер сходил.");
                            draw_fild(fild);
                            end_game = game_over(fild, playing_with)[8];
                            if (playing_with == 'O')
                            {
                                playing_with = 'Х';
                            }
                            else
                            {
                                playing_with = 'O';
                            }
                        }
                    }
                }
            }
            if (playing_with == 'O')
            {
                playing_with = 'Х';
            }
            else
            {
                playing_with = 'O';
            }
            if (end_game != -1)
            {
                draw_winner(fild, end_game);
                Console.WriteLine(playing_with + " wins! Congratulations!");
            }
            else
            {
                Console.WriteLine("Похоже ничья парни.");
            }
        }
    }
}
