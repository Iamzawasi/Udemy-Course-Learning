int num=650; //(32 bit)

float floatNum=3.3f; //(32 bit)//We need m with Decimal to till the compiler that the literal is a specific type
double doubNum=3.333333333333; //(64 bit)
decimal decNum=3.3m; //(128 bit)// here we need to letter m
string abc;
string str="this is a string";
char chr='u'; //( 16 bit); // we can save only one character with char type in c#
var typeNotSpciecid="Hi now my type is String"; // declartiong of variable with var

int[] intArray=new int[]{1,2,3,4,5,6,7,8,9,10}; 

for(int i=0; i<intArray.Length; i++){
    Console.WriteLine("I am for loop: "+intArray[i]);
}
int interations=0;
while(interations<intArray.Length){
    Console.WriteLine("I am for while: "+intArray[interations]);
    interations++;
}

int inter=0;
do{
   Console.WriteLine("I am do while: "+intArray[inter]); 
   inter++;
}while(inter==100); // we have the condition at the end even if the condition is wrong the loop will load once 
//while(inter<intArray.Length)// correct condition is here

foreach(var item in intArray){
   Console.WriteLine("I am foreach loop "+intArray[item]);
}