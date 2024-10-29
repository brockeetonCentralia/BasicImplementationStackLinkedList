using BasicImplementationStackLinkedList;

StackUsingLinkedList<int> stack = new StackUsingLinkedList<int>();

// Push elements onto the stack
stack.Push(10); // Stack: 10
stack.Push(20); // Stack: 20, 10
stack.Push(30); // Stack: 30, 20, 10

// Peek the top element
Console.WriteLine($"Top element is {stack.Peek()}"); // Output: Top element is 30

// Pop elements from the stack
stack.Pop(); // Removes 30, Stack: 20, 10
stack.Pop(); // Removes 20, Stack: 10

// Check if the stack is empty
Console.WriteLine($"Is stack empty? {stack.IsEmpty()}");

stack.Pop();

Console.WriteLine($"Top element is {stack.Peek()}");

Console.WriteLine($"Is stack empty? {stack.IsEmpty()}");
