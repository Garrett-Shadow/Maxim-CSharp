Console.WriteLine("Введите строку");
string st = Convert.ToString(Console.ReadLine());
if (st.Length % 2 == 0)
{
    string sta = st.Substring(0, st.Length / 2);
    string stb = st.Substring(st.Length / 2, st.Length - st.Length / 2);
    string revsta = new string(sta.ToCharArray().Reverse().ToArray());
    string revstb = new string(stb.ToCharArray().Reverse().ToArray());
    string newst = revsta + revstb;
    Console.WriteLine(newst);
    Console.ReadKey();
}
else
{
    string stc = st;
    string revst = new string(st.ToCharArray().Reverse().ToArray());
    string newst = revst + stc;
    Console.WriteLine(newst);
    Console.ReadKey();
}