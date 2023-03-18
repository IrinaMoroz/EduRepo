using System.Text.RegularExpressions;

public class Solution {
    //["cat","cats","catsdogcats","dog","dogcatsdog","hippopotamuses","rat","ratcatdogcat"]
    public List<string> FindAllConcatenatedWordsInADict(string[] words) {
        var resList = new List<string>();
        var dict  = new Dictionary<string, List<string>>();
        var wholeList = new System.Collections.Generic.HashSet<string>();
        for (int i = 0; i < words.Length; i++)
        {
            string? currentWord = words[i];
            //if (resList.Contains(currentWord)) continue;
            //if (wholeList.Contains(currentWord)) 
            for (int j = 0; j < words.Length; j++)
            {
                if (words[j] != currentWord && words[j].Contains(currentWord))
                {
                    // if (!dict.TryGetValue(currentWord, out List<string> wordLst))
                    // {
                    //     wordLst = new List<string>();
                    //     dict.Add(currentWord, wordLst);
                    // }
                    // wordLst.Add(words[j]);
                    if (!resList.Contains(words[j])) resList.Add(words[j]);
                    if (!wholeList.Contains(currentWord)) wholeList.Add(currentWord);

                }
            }           

        }
        Print("resList", resList);
        Print("wholeList", wholeList);

        Regex dupRegex = new Regex(@"(.+)\1", RegexOptions.IgnoreCase);
//resList: cats;catsdogcats;dogcatsdogy;ratcatdogcat
//wholeList: cat;cats;dog;rat
        foreach(var current in resList.ToList())
        {
            var partsLength = 0;
            foreach (var whole in wholeList)
            {
                if (current == whole) {
                    break;
                }
                var allMatches = Regex.Matches(current, whole);
                Console.WriteLine($"{current}-{whole}: {allMatches.Count}");
                if (allMatches.Count != 0) {
                    partsLength += whole.Length * allMatches.Count;
                }
            }
            if (partsLength != current.Length)
            {                
                Console.WriteLine($"Removing {current}");

                resList.Remove(current);                
            }
        }

        Print("resList", resList);

        // foreach (var kp in dict){
        //     Console.WriteLine($"{kp.Key}: [{string.Join(";", kp.Value)}]");
        // }
        return resList;
    }

    private void Print(string name, IEnumerable<string> arr){
        Console.WriteLine(name + ": "+ string.Join(";", arr));
    }

    public List<string> FindAllConcatenatedWordsInADict_(string[] words) {
        var resList = new List<string>();
        for (int i = 0; i < words.Length; i++)
        {
            string? currentWord = words[i];
            if (resList.Contains(currentWord)) continue;
            for (int j = i; j < words.Length; j++)
            {
                if (!resList.Contains(words[j])
                    && (words[j].Length != currentWord.Length 
                    )
                    && words[j].Contains(currentWord))
                {
                    resList.Add(words[j]);
                }
            }
        }
        return resList;
    }
}