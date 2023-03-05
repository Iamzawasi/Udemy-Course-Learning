using System.Collections.Generic;
///we can't change the size of the array after its declaration
// the size of array need to be fixed,but the size of list is dynamic

List<string> li = new List<string>(){"Zebra", "Tiger", "cat"}; 
///string li = new List<string>(){"Zebra", "Tiger", "cat"};  this kind of list works only inside method
li.Add("dog");
Console.WriteLine("after adding an item "+li.Count);

li.Remove("cat");
Console.WriteLine("after removing an item "+li.Count);

foreach(var item in li){
    Console.Write(item+", ");
}