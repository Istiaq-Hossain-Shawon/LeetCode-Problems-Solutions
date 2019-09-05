     public static void Main(string[] args)
        {
          allPalindromicSubStrings("civilwartestingwhetherthatnaptionoranynartionsoconceivedandsodedicatedcanlongendureWeareqmetonagreatbattlefiemldoftzhatwarWehavecometodedicpateaportionofthatfieldasafinalrestingplaceforthosewhoheregavetheirlivesthatthatnationmightliveItisaltogetherfangandproperthatweshoulddothisButinalargersensewecannotdedicatewecannotconsecratewecannothallowthisgroundThebravelmenlivinganddeadwhostruggledherehaveconsecrateditfaraboveourpoorponwertoaddordetractTgheworldadswfilllittlenotlenorlongrememberwhatwesayherebutitcanneverforgetwhattheydidhereItisforusthelivingrathertobededicatedheretotheulnfinishedworkwhichtheywhofoughtherehavethusfarsonoblyadvancedItisratherforustobeherededicatedtothegreattdafskremainingbeforeusthatfromthesehonoreddeadwetakeincreaseddevotiontothatcauseforwhichtheygavethelastpfullmeasureofdevotionthatweherehighlyresolvethatthesedeadshallnothavediedinvainthatthisnationunsderGodshallhaveanewbirthoffreedomandthatgovernmentofthepeoplebythepeopleforthepeopleshallnotperishfromtheearth");
            
            allPalindromicSubStrings("madam");
            
            Console.ReadLine();

        }  

  // expand in both directions of low and high to find all palindromes
        public static void expand(String str, int low, int high, List<string> set)
        {
            // run till str[low.high] is a palindrome
            while (low >= 0 && high < str.Length
                    && str[low] == str[high])
            {
                // push all palindromes into the set
                set.Add(str.Substring(low, high - low + 1));
                // expand in both directions
                low--;
                high++;
            }
        }

        // Function to find all unique palindromic substrings of given String
        public static void allPalindromicSubStrings(String str)
        {
            // create an empty set to store all unique palindromic substrings
            List<string> set = new List<string>();

            for (int i = 0; i < str.Length; i++)
            {
                // find all odd length palindrome with str[i] as mid point
                expand(str, i, i, set);

                // find all even length palindrome with str[i] and str[i+1]
                // as its mid points
                expand(str, i, i + 1, set);
            }

            // print all unique palindromic substrings
            //System.out.print(set);
            foreach (var data in set) {
                Console.WriteLine(data);

            }
        }
        /* Driver program to test all above functions */