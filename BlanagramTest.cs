using System;
using System.Collections.Generic;
using System.Linq;


namespace BlanagramTester
{
      static bool IsBlanagram1(string word1, string word2)
      {
          if (word1.Length != word2.Length) return false;

          word1 = word1.ToLower();
          word2 = word2.ToLower();

          bool isAnagramAlready = IsAnagram(word1, word2);
          if (isAnagramAlready) return false;

          var hash1 = new HashSet<char>(word1); //takes only unique characters in Hashset
          var hash2 = new HashSet<char>(word2);

          var commonHash = new HashSet<char>(word1); 

          commonHash.IntersectWith(hash2); //get common of both

          hash1.ExceptWith(commonHash); //get without common
          hash2.ExceptWith(commonHash);

          var lenHash1 = hash1.Count();
          var lenHash2 = hash2.Count();

          var condition = ((lenHash1 == 1 && lenHash2 == 0) || (lenHash1 == 1 && lenHash2 == 0) || (lenHash1 == 1 && lenHash2 == 1));


          if (condition)
              return true;

          return false;
      }
      
      static bool IsAnagram(string world1, string word2)
      {
          string s1 = String.Concat(world1.OrderBy(w1 => w1));
          string s2 = String.Concat(word2.OrderBy(w2 => w2));

          return s1 == s2;
      }
      
      static void Main(string[] args)
      { 
          string word1 = "tangram"; //tangram, abbt, tangram, silent
          string word2 = "pangtam"; //anagram, baby, pangram, listen
          
          //Expected Outputs: true, true, true, false

          Console.WriteLine("Input words:\n{0} \t {1}\n", word1, word2);

          bool c = IsBlanagram(word1, word2);
          Console.WriteLine(c);

          Console.ReadKey();
      }
}
