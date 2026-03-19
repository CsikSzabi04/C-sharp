using System;
using System.Collections.Generic;
using System.Text;

namespace Statics01{
    internal class Class1{
        public static int GetMin(int[] a){
            int min = a[0];
            for (int i = 1; i < a.Length; i++) if(a[i] < min) min = a[i];
            return min;
        }

        public static int GetMax(int[] a){
            int max = a[0];
            for(int i = 1;i < a.Length;i++) if(a[(int)a[i]] > max) max = a[i];
            return max;
        }

        public static int[] GetUnique(int[] a){
            int[] uniqe;    
            List<int> list = new List<int>();
            for(int i = 0; i< a.Length; i++){
                if (!list.Contains(a[i])) list.Add(a[i]);
            }
            uniqe = list.ToArray(); 
            return uniqe;
        }

        //public static int[] GetFrequency(int[] a, int[] u,){
        //    int[] freq;
        //    return freq;
        //}
    }
}
