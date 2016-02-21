using System;
using Shell32;

class ShowID3Tags
{
    static void Main()
    {

        string dir = @"C:\Users\ryu\Desktop"; // MP3ファイルのあるディレクトリ
        string file = "1-16 I Will.mp3";

        ShellClass shell = new ShellClass();
        Folder f = shell.NameSpace(dir);
        FolderItem item = f.ParseName(file);
        for (int i = 0; i < 200; i++)
        {
            if (!string.IsNullOrEmpty(f.GetDetailsOf(item, i))){
                 Console.WriteLine(f.GetDetailsOf(item, i)); // アーティスト
            }
           
        }
    }
}