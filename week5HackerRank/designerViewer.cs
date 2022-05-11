  
  //enumerable.range is a visual Basic that contains a range of sequential integral numbers.
  char[] alphabet = Enumerable.Range('a', 26).Select(x => (char)x).ToArray();
        
        int Size = 0;
        for(int i = 0; i < word.Length; i++)
        {
            int indexOfChar = Array.IndexOf(alphabet, word[i]);
            
            if(h[indexOfChar] >= Size)
                Size = h[indexOfChar];
        }
        
        return Size * word.Length;



//marks way
        int [] intArr = new int[word.Length];
       for(int x=0; x<intArr.Length; x++)
       {
          intArr[x] = word[x]-97; //ascii value of a 
       }
       for(int y=0; y<intArr.Length; y++)
       {
           intArr[y] = h[intArr[y]];
       }
       int maxVal = intArr.Max();
       return maxVal*intArr.Count();