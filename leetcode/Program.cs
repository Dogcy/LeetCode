string s = "zsafdfa";

 var result =
    Func.Firstchar(s);
Console.Write(result);
Console.Read();



    public static class Func
{
    public static int Firstchar(string s)
    {

        //根據 char ascii code 的特性 
        // A - Z  65 ~90
        // a - z  97 ~122
        int[] array = new int[128];
        for (int i = 0; i < s.Length; i++)
        {
            // 利用char ascii code寫入array index 
            array[s[i]]++;
        }

        for (int i = 0; i < s.Length; i++)
        {
            // 判斷是否是一(只有一個)
            if (array[s[i]] == 1)
            {
                return i;
            }
        }
        return -1;
    }
}