Stack<int> myStack  = new Stack<int>();
Console.WriteLine("After push:");
myStack.Push(1);
myStack.Push(2);
myStack.Push(3);
myStack.Push(4);

foreach (int i in myStack)
{
    Console.WriteLine(i);
}

myStack.Pop();
Console.WriteLine("After pop: ");

foreach (int i in myStack)
{
    Console.WriteLine(i);
}