﻿using EasyCollection.Tasks.Abstraction;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace EasyCollection.Tasks.StringTasks
{
    internal class ValidAnagramTask : MultipleArrayBaseTask<char,bool>
    {
        private char[] word1, word2;
        private int[] charMap = new int[26];
        
        public ValidAnagramTask(string s1, string s2) : base(new List<char[]> { s1.ToCharArray(), s2.ToCharArray()})
        {
            word1 = multipleArrayBaseTaskParams.Input[0];
            word2 = multipleArrayBaseTaskParams.Input[1];
        }

        protected override bool Solve()
        {
            if (!LengthsAreEqual())
                return false;

            for(int i = 0; i < word1.Length; i++)
            {
                charMap[word1[i] - 'a']++;
                charMap[word2[i] - 'a']--;
            }

            return charMap.All(c => c == 0);

        }
        private bool LengthsAreEqual() => word1.Length == word2.Length;
    }
}
