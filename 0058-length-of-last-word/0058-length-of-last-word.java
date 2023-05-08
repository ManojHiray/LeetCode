class Solution 
{
    public int lengthOfLastWord(String str) 
    {
        //String[] words = str.split(" ");
        //return words.length == 0 ? 0 : words[words.length-1].length();
        string str = s.TrimEnd();
        int count = 0;
        for(int i = str.Length-1; i >= 0; i--)
        {
            if(str[i] != ' ')
            {
                count++;
            }
            if(str[i] == ' ')
            {
                break;
            }
        }
        return count;
    }
}
