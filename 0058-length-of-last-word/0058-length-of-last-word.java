class Solution {
    public int lengthOfLastWord(String str) {
        String[] words = str.split(" ");
        return words.length == 0 ? 0 : words[words.length-1].length();
    }
}