using System; 
  
public class WordLength 
{ 
  
    static String minWord = "", maxWord = ""; 
  
    public static void minMaxLengthWords(String input)  
    { 
        int len = input.Length; 
        int si = 0, ei = 0; 
        int min_length = len, min_start_index = 0, 
            max_length = 0, max_start_index = 0; 
  
        while (ei <= len)  
        { 
            if (ei < len && input[ei] != ' ') 
            { 
                ei++; 
            }  
            else
            { 
                int curr_length = ei - si; 
  
                if (curr_length < min_length)  
                { 
                    min_length = curr_length; 
                    min_start_index = si; 
                } 
  
                if (curr_length > max_length)  
                { 
                    max_length = curr_length; 
                    max_start_index = si; 
                } 
                ei++; 
                si = ei; 
            } 
        } 
  
        minWord = input.Substring(min_start_index, min_length); 
        maxWord = input.Substring(max_start_index, max_length); 
    } 
  
    public static void Main(String[] args) 
    { 
        String a = "This is a test string!"; 
  
        minMaxLengthWords(a); 
  
        Console.Write("Minimum length word: "
                + minWord 
                + "\nMaximum length word: "
                + maxWord); 
    } 
} 
