using System;


class simpleCal{
    
// find all the number from 1 to 100 which are divisble by 3 ?
    static void Main(){
            int maxInt=3; // here i am excaping 1 and 2 bcz they are not dividable by 3 
        while (maxInt<=100){
            int isZero=maxInt % 3;
            if(isZero==0){  // we can further enhance the code by changing the if condition (!Convert.ToBoolean(isZero))
                Console.WriteLine(maxInt);
            }
            maxInt++;
        }
    }

}