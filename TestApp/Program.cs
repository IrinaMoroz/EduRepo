//Console.WriteLine(string.Join(";", Deadfish.Parse("iiisdosodddddiso")));
using System.Diagnostics;


Run(new Solution().FindAllConcatenatedWordsInADict, new string[]{"cat","cats","catsdogcats","dog","dogcatsdog","dogcatsdogy","hippopotamuses","rat","ratcatdogcat"});

//Run(new Solution().FindAllConcatenatedWordsInADict, new string[]{"a","b","ab","abc"});

/*
st.Reset();
st.Start();
var res2 =  new Solution().FindAllConcatenatedWordsInADict(new string[]{"pizza","animal","green", "greenpizza"});
st.Stop();
Console.WriteLine(st.Elapsed.ToString("ss\\.ff") + " "+ string.Join(";",res2));
*/

void Run(Func<string[], IList<string>> inptAction, string[] inptArg)
{    
    var st = new Stopwatch();
    st.Start();
    var result = inptAction(inptArg);
    st.Stop();
    Console.WriteLine(st.Elapsed.ToString(@"m\:ss\.fffff") + " "+ string.Join(";", result));
}
