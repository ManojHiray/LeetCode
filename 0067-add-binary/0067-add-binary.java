class Solution                                  //ASCII '0'=48 '1'=49
{
    public String addBinary(String a, String b) //1010 , 1011
    {
        StringBuilder sb = new StringBuilder();
        
        int i = a.length() - 1, j = b.length() -1, carry = 0;//3,3,0
        
        while (i >= 0 || j >= 0) 
        {
            int sum = carry;
            if (j >= 0)
            {
                sum += b.charAt(j--) - '0';//1
            }
            if (i >= 0) 
            {
                sum += a.charAt(i--) - '0';//1
            }
            sb.append(sum % 2);//0
            carry = sum / 2;
        }
        
        if (carry != 0)
        {
            sb.append(carry);
        }
        
        return sb.reverse().toString();
    }
}