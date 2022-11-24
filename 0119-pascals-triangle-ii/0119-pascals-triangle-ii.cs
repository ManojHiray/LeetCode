public class Solution 
{
    public IList<int> GetRow(int rowIndex) 
    {
        IList<int> myList = new List<int>();
        
        myList.Add(1);//0
        
        if(rowIndex == 0) return myList; //base case
        
        myList.Add(1);//1
        if(rowIndex == 1) return myList; //base case
        
        while(rowIndex != 1)
        {
            List<int> list = new List<int>();
            
            list.Add(1);//1st pos
            
            for(int i=0; i<myList.Count-1; i++)
            {
                list.Add(myList[i] + myList[i+1]);
            }
            
            list.Add(1);//last pos
            myList = list;
            rowIndex--;
        }
        return myList;
    }
}