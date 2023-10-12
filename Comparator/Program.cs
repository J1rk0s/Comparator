using System.Collections.Generic;
LinkedList<string> list = new();

list.AddLast(new LinkedListNode<string>("amongus1"));
list.AddLast(new LinkedListNode<string>("amongus2"));
list.AddLast(new LinkedListNode<string>("amongus3"));
list.AddLast(new LinkedListNode<string>("amongus4"));
list.AddLast(new LinkedListNode<string>("amongus5"));

Console.WriteLine(list?.First?.Value); // Vypíše hodnotu prvního node
Console.WriteLine(list?.First?.Next?.Value); // Vypíše hodnotu druhého node

foreach(var item in list) { // Výpíše hodnoty všech nodes
    Console.WriteLine(item);
}
