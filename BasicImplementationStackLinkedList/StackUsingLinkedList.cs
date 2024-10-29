using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicImplementationStackLinkedList
{
    public class StackUsingLinkedList<T>
    {
        private LinkedList<T> _list = new LinkedList<T>();

        // Push an item onto the stack (add to the front of the list)
        public void Push(T item)
        {
            _list.AddFirst(item); // Add to the front (head) of the list
            Console.WriteLine($"Pushed {item} to the stack.");
        }

        // Pop an item from the stack (remove from the front of the list)
        public T Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty.");
                return default;
            }
            T value = _list.First.Value;
            _list.RemoveFirst(); // Remove the front node
            Console.WriteLine($"Popped {value} from the stack.");
            return value;
        }

        // Peek at the top item of the stack (front of the list)
        public T Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty.");
                return default;
            }
            return _list.First.Value; // Return the value at the front
        }

        // Check if the stack is empty
        public bool IsEmpty() => _list.Count == 0;
    }
}
