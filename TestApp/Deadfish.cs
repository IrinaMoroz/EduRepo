public class Deadfish
    {
        private delegate void RefAction(ref int val);
        private static Dictionary<char, RefAction> doIt = new Dictionary<char, RefAction>{
            ['i'] = (ref int input) => input++,
             ['d'] = (ref int input) => input--,
             ['s'] = (ref int input) => input = input*input
        };

        public static int[] Parse(string data)
        {
            var result = new int[data.Count(x => x == 'o')];
            if (result.Length == 0) return new int[0];
            int initValue = 0, i = 0;
            foreach (char c in data)
            {
                if (c == 'o') 
                {
                    result[i++] = initValue;
                    continue;
                }
                if (!doIt.ContainsKey(c)) continue;
                doIt[c](ref initValue);
                Console.WriteLine(initValue);
            }

            return result;
        }
    }