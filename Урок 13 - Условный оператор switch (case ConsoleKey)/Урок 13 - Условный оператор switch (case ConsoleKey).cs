using System;
using System.Globalization;

/*
 * Условный оператор SWITCH
*/


namespace Lesson13
{
    class Program13
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.Write("Введите символ с клавиатуры: ");
                ConsoleKey consoleKey = Console.ReadKey().Key;
                Console.WriteLine();
                switch (consoleKey)
                {
                    case ConsoleKey.Backspace:
                        Console.WriteLine("Вы нажали Backspace");
                        break;
                    case ConsoleKey.Tab:
                        Console.WriteLine("Вы нажали Tab");
                        break;
                    case ConsoleKey.Clear:
                        Console.WriteLine("Вы нажали Clear");
                        break;
                    case ConsoleKey.Enter:
                        Console.WriteLine("Вы нажали Enter");
                        break;
                    case ConsoleKey.Pause:
                        Console.WriteLine("Вы нажали Pause");
                        break;
                    case ConsoleKey.Escape:
                        Console.WriteLine("Вы нажали Escape");
                        break;
                    case ConsoleKey.Spacebar:
                        Console.WriteLine("Вы нажали Пробел");
                        break;
                    case ConsoleKey.PageUp:
                        Console.WriteLine("Вы нажали PageUp");
                        break;
                    case ConsoleKey.PageDown:
                        Console.WriteLine("Вы нажали PageDown");
                        break;
                    case ConsoleKey.End:
                        Console.WriteLine("Вы нажали End");
                        break;
                    case ConsoleKey.Home:
                        Console.WriteLine("Вы нажали Home");
                        break;
                    case ConsoleKey.LeftArrow:
                        Console.WriteLine("Вы нажали LeftArrow");
                        break;
                    case ConsoleKey.UpArrow:
                        Console.WriteLine("Вы нажали UpArrow");
                        break;
                    case ConsoleKey.RightArrow:
                        Console.WriteLine("Вы нажали RightArrow");
                        break;
                    case ConsoleKey.DownArrow:
                        Console.WriteLine("Вы нажали DownArrow");
                        break;
                    case ConsoleKey.Select:
                        Console.WriteLine("Вы нажали Select");
                        break;
                    case ConsoleKey.Print:
                        Console.WriteLine("Вы нажали Print");
                        break;
                    case ConsoleKey.Execute:
                        Console.WriteLine("Вы нажали Execute");
                        break;
                    case ConsoleKey.PrintScreen:
                        Console.WriteLine("Вы нажали PrintScreen");
                        break;
                    case ConsoleKey.Insert:
                        Console.WriteLine("Вы нажали Insert");
                        break;
                    case ConsoleKey.Delete:
                        Console.WriteLine("Вы нажали Delete");
                        break;
                    case ConsoleKey.Help:
                        Console.WriteLine("Вы нажали Help");
                        break;
                    case ConsoleKey.D0:
                        Console.WriteLine("Вы нажали D0");
                        break;
                    case ConsoleKey.D1:
                        Console.WriteLine("Вы нажали D1");
                        break;
                    case ConsoleKey.D2:
                        Console.WriteLine("Вы нажали D2");
                        break;
                    case ConsoleKey.D3:
                        Console.WriteLine("Вы нажали D3");
                        break;
                    case ConsoleKey.D4:
                        Console.WriteLine("Вы нажали D4");
                        break;
                    case ConsoleKey.D5:
                        Console.WriteLine("Вы нажали D5");
                        break;
                    case ConsoleKey.D6:
                        Console.WriteLine("Вы нажали D6");
                        break;
                    case ConsoleKey.D7:
                        Console.WriteLine("Вы нажали D7");
                        break;
                    case ConsoleKey.D8:
                        Console.WriteLine("Вы нажали D8");
                        break;
                    case ConsoleKey.D9:
                        Console.WriteLine("Вы нажали D9");
                        break;
                    case ConsoleKey.A:
                        Console.WriteLine("Вы нажали A");
                        break;
                    case ConsoleKey.B:
                        Console.WriteLine("Вы нажали B");
                        break;
                    case ConsoleKey.C:
                        Console.WriteLine("Вы нажали C");
                        break;
                    case ConsoleKey.D:
                        Console.WriteLine("Вы нажали D");
                        break;
                    case ConsoleKey.E:
                        Console.WriteLine("Вы нажали E");
                        break;
                    case ConsoleKey.F:
                        Console.WriteLine("Вы нажали F");
                        break;
                    case ConsoleKey.G:
                        Console.WriteLine("Вы нажали G");
                        break;
                    case ConsoleKey.H:
                        Console.WriteLine("Вы нажали H");
                        break;
                    case ConsoleKey.I:
                        Console.WriteLine("Вы нажали I");
                        break;
                    case ConsoleKey.J:
                        Console.WriteLine("Вы нажали J");
                        break;
                    case ConsoleKey.K:
                        Console.WriteLine("Вы нажали K");
                        break;
                    case ConsoleKey.L:
                        Console.WriteLine("Вы нажали L");
                        break;
                    case ConsoleKey.M:
                        Console.WriteLine("Вы нажали M");
                        break;
                    case ConsoleKey.N:
                        Console.WriteLine("Вы нажали N");
                        break;
                    case ConsoleKey.O:
                        Console.WriteLine("Вы нажали O");
                        break;
                    case ConsoleKey.P:
                        Console.WriteLine("Вы нажали P");
                        break;
                    case ConsoleKey.Q:
                        Console.WriteLine("Вы нажали Q");
                        break;
                    case ConsoleKey.R:
                        Console.WriteLine("Вы нажали R");
                        break;
                    case ConsoleKey.S:
                        Console.WriteLine("Вы нажали S");
                        break;
                    case ConsoleKey.T:
                        Console.WriteLine("Вы нажали T");
                        break;
                    case ConsoleKey.U:
                        Console.WriteLine("Вы нажали U");
                        break;
                    case ConsoleKey.V:
                        Console.WriteLine("Вы нажали V");
                        break;
                    case ConsoleKey.W:
                        Console.WriteLine("Вы нажали W");
                        break;
                    case ConsoleKey.X:
                        Console.WriteLine("Вы нажали X");
                        break;
                    case ConsoleKey.Y:
                        Console.WriteLine("Вы нажали Y");
                        break;
                    case ConsoleKey.Z:
                        Console.WriteLine("Вы нажали Z");
                        break;
                    case ConsoleKey.LeftWindows:
                        Console.WriteLine("Вы нажали LeftWindows");
                        break;
                    case ConsoleKey.RightWindows:
                        Console.WriteLine("Вы нажали RightWindows");
                        break;
                    case ConsoleKey.Applications:
                        Console.WriteLine("Вы нажали Applications");
                        break;
                    case ConsoleKey.Sleep:
                        Console.WriteLine("Вы нажали Sleep");
                        break;
                    case ConsoleKey.NumPad0:
                        Console.WriteLine("Вы нажали NumPad0");
                        break;
                    case ConsoleKey.NumPad1:
                        Console.WriteLine("Вы нажали NumPad1");
                        break;
                    case ConsoleKey.NumPad2:
                        Console.WriteLine("Вы нажали NumPad2");
                        break;
                    case ConsoleKey.NumPad3:
                        Console.WriteLine("Вы нажали NumPad3");
                        break;
                    case ConsoleKey.NumPad4:
                        Console.WriteLine("Вы нажали NumPad4");
                        break;
                    case ConsoleKey.NumPad5:
                        Console.WriteLine("Вы нажали NumPad5");
                        break;
                    case ConsoleKey.NumPad6:
                        Console.WriteLine("Вы нажали NumPad6");
                        break;
                    case ConsoleKey.NumPad7:
                        Console.WriteLine("Вы нажали NumPad7");
                        break;
                    case ConsoleKey.NumPad8:
                        Console.WriteLine("Вы нажали NumPad8");
                        break;
                    case ConsoleKey.NumPad9:
                        Console.WriteLine("Вы нажали NumPad9");
                        break;
                    case ConsoleKey.Multiply:
                        Console.WriteLine("Вы нажали Multiply");
                        break;
                    case ConsoleKey.Add:
                        Console.WriteLine("Вы нажали Add");
                        break;
                    case ConsoleKey.Separator:
                        Console.WriteLine("Вы нажали Separator");
                        break;
                    case ConsoleKey.Subtract:
                        Console.WriteLine("Вы нажали Subtract");
                        break;
                    case ConsoleKey.Decimal:
                        Console.WriteLine("Вы нажали Decimal");
                        break;
                    case ConsoleKey.Divide:
                        Console.WriteLine("Вы нажали Divide");
                        break;
                    case ConsoleKey.F1:
                        Console.WriteLine("Вы нажали F1");
                        break;
                    case ConsoleKey.F2:
                        Console.WriteLine("Вы нажали F2");
                        break;
                    case ConsoleKey.F3:
                        Console.WriteLine("Вы нажали F3");
                        break;
                    case ConsoleKey.F4:
                        Console.WriteLine("Вы нажали F4");
                        break;
                    case ConsoleKey.F5:
                        Console.WriteLine("Вы нажали F5");
                        break;
                    case ConsoleKey.F6:
                        Console.WriteLine("Вы нажали F6");
                        break;
                    case ConsoleKey.F7:
                        Console.WriteLine("Вы нажали F7");
                        break;
                    case ConsoleKey.F8:
                        Console.WriteLine("Вы нажали F8");
                        break;
                    case ConsoleKey.F9:
                        Console.WriteLine("Вы нажали F9");
                        break;
                    case ConsoleKey.F10:
                        Console.WriteLine("Вы нажали F10");
                        break;
                    case ConsoleKey.F11:
                        Console.WriteLine("Вы нажали F11");
                        break;
                    case ConsoleKey.F12:
                        Console.WriteLine("Вы нажали F12");
                        break;
                    case ConsoleKey.F13:
                        Console.WriteLine("Вы нажали F13");
                        break;
                    case ConsoleKey.F14:
                        Console.WriteLine("Вы нажали F14");
                        break;
                    case ConsoleKey.F15:
                        Console.WriteLine("Вы нажали F15");
                        break;
                    case ConsoleKey.F16:
                        Console.WriteLine("Вы нажали F16");
                        break;
                    case ConsoleKey.F17:
                        Console.WriteLine("Вы нажали F17");
                        break;
                    case ConsoleKey.F18:
                        Console.WriteLine("Вы нажали F18");
                        break;
                    case ConsoleKey.F19:
                        Console.WriteLine("Вы нажали F19");
                        break;
                    case ConsoleKey.F20:
                        Console.WriteLine("Вы нажали F20");
                        break;
                    case ConsoleKey.F21:
                        Console.WriteLine("Вы нажали F21");
                        break;
                    case ConsoleKey.F22:
                        Console.WriteLine("Вы нажали F22");
                        break;
                    case ConsoleKey.F23:
                        Console.WriteLine("Вы нажали F23");
                        break;
                    case ConsoleKey.F24:
                        Console.WriteLine("Вы нажали F24");
                        break;
                    case ConsoleKey.BrowserBack:
                        Console.WriteLine("Вы нажали BrowserBack");
                        break;
                    case ConsoleKey.BrowserForward:
                        Console.WriteLine("Вы нажали BrowserForward");
                        break;
                    case ConsoleKey.BrowserRefresh:
                        Console.WriteLine("Вы нажали BrowserRefresh");
                        break;
                    case ConsoleKey.BrowserStop:
                        Console.WriteLine("Вы нажали BrowserStop");
                        break;
                    case ConsoleKey.BrowserSearch:
                        Console.WriteLine("Вы нажали BrowserSearch");
                        break;
                    case ConsoleKey.BrowserFavorites:
                        Console.WriteLine("Вы нажали BrowserFavorites");
                        break;
                    case ConsoleKey.BrowserHome:
                        Console.WriteLine("Вы нажали BrowserHome");
                        break;
                    case ConsoleKey.VolumeMute:
                        Console.WriteLine("Вы нажали VolumeMute");
                        break;
                    case ConsoleKey.VolumeDown:
                        Console.WriteLine("Вы нажали VolumeDown");
                        break;
                    case ConsoleKey.VolumeUp:
                        Console.WriteLine("Вы нажали VolumeUp");
                        break;
                    case ConsoleKey.MediaNext:
                        Console.WriteLine("Вы нажали MediaNext");
                        break;
                    case ConsoleKey.MediaPrevious:
                        Console.WriteLine("Вы нажали MediaPrevious");
                        break;
                    case ConsoleKey.MediaStop:
                        Console.WriteLine("Вы нажали MediaStop");
                        break;
                    case ConsoleKey.MediaPlay:
                        Console.WriteLine("Вы нажали MediaPlay");
                        break;
                    case ConsoleKey.LaunchMail:
                        Console.WriteLine("Вы нажали LaunchMail");
                        break;
                    case ConsoleKey.LaunchMediaSelect:
                        Console.WriteLine("Вы нажали LaunchMediaSelect");
                        break;
                    case ConsoleKey.LaunchApp1:
                        Console.WriteLine("Вы нажали LaunchApp1");
                        break;
                    case ConsoleKey.LaunchApp2:
                        Console.WriteLine("Вы нажали LaunchApp2");
                        break;
                    case ConsoleKey.Oem1:
                        Console.WriteLine("Вы нажали Oem1");
                        break;
                    case ConsoleKey.OemPlus:
                        Console.WriteLine("Вы нажали OemPlus");
                        break;
                    case ConsoleKey.OemComma:
                        Console.WriteLine("Вы нажали OemComma");
                        break;
                    case ConsoleKey.OemMinus:
                        Console.WriteLine("Вы нажали OemMinus");
                        break;
                    case ConsoleKey.OemPeriod:
                        Console.WriteLine("Вы нажали OemPeriod");
                        break;
                    case ConsoleKey.Oem2:
                        Console.WriteLine("Вы нажали Oem2");
                        break;
                    case ConsoleKey.Oem3:
                        Console.WriteLine("Вы нажали Oem3");
                        break;
                    case ConsoleKey.Oem4:
                        Console.WriteLine("Вы нажали Oem4");
                        break;
                    case ConsoleKey.Oem5:
                        Console.WriteLine("Вы нажали Oem5");
                        break;
                    case ConsoleKey.Oem6:
                        Console.WriteLine("Вы нажали Oem6");
                        break;
                    case ConsoleKey.Oem7:
                        Console.WriteLine("Вы нажали Oem7");
                        break;
                    case ConsoleKey.Oem8:
                        Console.WriteLine("Вы нажали Oem8");
                        break;
                    case ConsoleKey.Oem102:
                        Console.WriteLine("Вы нажали Oem102");
                        break;
                    case ConsoleKey.Process:
                        Console.WriteLine("Вы нажали Process");
                        break;
                    case ConsoleKey.Packet:
                        Console.WriteLine("Вы нажали Packet");
                        break;
                    case ConsoleKey.Attention:
                        Console.WriteLine("Вы нажали Attention");
                        break;
                    case ConsoleKey.CrSel:
                        Console.WriteLine("Вы нажали CrSel");
                        break;
                    case ConsoleKey.ExSel:
                        Console.WriteLine("Вы нажали ExSel");
                        break;
                    case ConsoleKey.EraseEndOfFile:
                        Console.WriteLine("Вы нажали EraseEndOfFile");
                        break;
                    case ConsoleKey.Play:
                        Console.WriteLine("Вы нажали Play");
                        break;
                    case ConsoleKey.Zoom:
                        Console.WriteLine("Вы нажали Zoom");
                        break;
                    case ConsoleKey.NoName:
                        Console.WriteLine("Вы нажали NoName");
                        break;
                    case ConsoleKey.Pa1:
                        Console.WriteLine("Вы нажали Pa1");
                        break;
                    case ConsoleKey.OemClear:
                        Console.WriteLine("Вы нажали OemClear");
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
