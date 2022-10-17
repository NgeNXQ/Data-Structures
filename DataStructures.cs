namespace DataStructures
{
    #region Linked List
    internal sealed class LinkedList<T>
    {
        private LinkedListNode<T>? head;
        private LinkedListNode<T>? tail;

        private int count;

        public LinkedList() { }

        public LinkedList(T value) { this.AddLast(value); }

        public LinkedList(params T[] values)
        {
            foreach (T item in values)
                this.AddLast(item);
        }

        public LinkedListNode<T> First { get => head; }
        public LinkedListNode<T> Last { get => tail; }

        public int Count { get => count; }

        public void AddFirst(LinkedListNode<T> node)
        {
            if (node == null)
                throw new System.ArgumentNullException($"{nameof(node)} is null.");
            else
            {
                node.Next = head;
                head = node;

                ++count;
            }
        }

        public LinkedListNode<T> AddFirst(T item)
        {
            LinkedListNode<T> newNode = new LinkedListNode<T>(item);

            newNode.Next = head;
            head = newNode;

            ++count;

            return newNode;
        }

        public void AddLast(LinkedListNode<T> node)
        {
            if(node == null)
                throw new ArgumentNullException($"{nameof(node)} is null.");

            if (head == null)
            {
                head = node;
                tail = node;
            }
            else
            {
                tail.Next = node;
                tail = node;
            }

            ++count;
        }

        public LinkedListNode<T> AddLast(T item)
        {
            LinkedListNode<T> newNode = new LinkedListNode<T>(item);

            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail.Next = newNode;
                tail = newNode;
            }

            ++count;

            return newNode;
        }

        public void AddAfter(LinkedListNode<T> node, LinkedListNode<T> newNode)
        {
            if (node == null)
                throw new System.ArgumentNullException($"{nameof(node)} is null.");
            else if(newNode == null)
                throw new System.ArgumentNullException($"{nameof(newNode)} is null.");
            else
            {
                LinkedListNode<T> current = head;

                while (current != null)
                {
                    if (current == node)
                    {
                        newNode.Next = current.Next;
                        current.Next = newNode;
                        ++count;
                        break;
                    }

                    current = current.Next;
                }
            }

            //    //   T:System.InvalidOperationException:
            //    //     node is not in the current System.Collections.Generic.LinkedList`1. -or- newNode
            //    //     belongs to another System.Collections.Generic.LinkedList
        }

        public LinkedListNode<T> AddAfter(LinkedListNode<T> node, T item)
        {
            if (node == null)
                throw new System.ArgumentNullException($"{nameof(node)} is null.");

            LinkedListNode<T> newNode = new LinkedListNode<T>(item);
            LinkedListNode<T> current = head;

            while (current != null)
            {
                if (current == node)
                {
                    newNode.Next = current.Next;
                    current.Next= newNode;
                    ++count;
                    break; 
                }

                current = current.Next;
            }

            return newNode;

            //   T:System.InvalidOperationException:
        }

        public void RemoveFirst()
        {
            if (head == null)
                throw new System.InvalidOperationException($"The {nameof(DataStructures.LinkedList<T>)} is empty.");

            head = head.Next;
            --count;
        }

        public void RemoveLast()        //Broken
        {
            if (head == null)
                throw new System.InvalidOperationException($"The {nameof(DataStructures.LinkedList<T>)} is empty.");

            tail = null;
            --count;
        }

        public bool Remove(LinkedListNode<T> node)
        {
            if (node == null)
                throw new System.ArgumentNullException($"{nameof(node)} is null.");

            if (head == null)
                return false;


            LinkedListNode<T> current = head;

            while (current.Next != null)
            {
                if(current.Next == node)
                {
                    current = current.Next.Next;
                    --count;
                    return true;
                }

                current = current.Next;
            }

            return false;
        }

        public bool Remove(T item)
        {
            // Summary:
            //     Removes the first occurrence of the specified value from the System.Collections.Generic.LinkedList`1.
            //
            // Parameters:
            //   value:
            //     The value to remove from the System.Collections.Generic.LinkedList`1.
            //
            // Returns:
            //     true if the element containing value is successfully removed; otherwise, false.
            //     This method also returns false if value was not found in the original System.Collections.Generic.LinkedList`1

            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            LinkedListNode<T> current = head;

            while (current != null)
            {
                if (current.Value != null)
                {
                    if (current.Value.Equals(item))
                        return true;
                }
                else
                {
                    if (item == null)
                        return true;
                }

                current = current.Next;
            }

            return false;
        }

        public void AddBefore(LinkedListNode<T> node, LinkedListNode<T> newNode)
        {
            // Summary:
            //     Adds the specified new node before the specified existing node in the System.Collections.Generic.LinkedList`1.
            //
            // Parameters:
            //   node:
            //     The System.Collections.Generic.LinkedListNode`1 before which to insert newNode.
            //
            //   newNode:
            //     The new System.Collections.Generic.LinkedListNode`1 to add to the System.Collections.Generic.LinkedList`1.
            //
            // Exceptions:
            //   T:System.ArgumentNullException:
            //     node is null. -or- newNode is null.
            //
            //   T:System.InvalidOperationException:
            //     node is not in the current System.Collections.Generic.LinkedList`1. -or- newNode
            //     belongs to another System.Collections.Generic.LinkedList`1.
        }

        public LinkedListNode<T> AddBefore(LinkedListNode<T> node, T value)
        {
            // Summary:
            //     Adds a new node containing the specified value before the specified existing
            //     node in the System.Collections.Generic.LinkedList`1.
            //
            // Parameters:
            //   node:
            //     The System.Collections.Generic.LinkedListNode`1 before which to insert a new
            //     System.Collections.Generic.LinkedListNode`1 containing value.
            //
            //   value:
            //     The value to add to the System.Collections.Generic.LinkedList`1.
            //
            // Returns:
            //     The new System.Collections.Generic.LinkedListNode`1 containing value.
            //
            // Exceptions:
            //   T:System.ArgumentNullException:
            //     node is null.
            //
            //   T:System.InvalidOperationException:
            //     node is not in the current System.Collections.Generic.LinkedList`1.

            throw new NotImplementedException();
        }

        public LinkedListNode<T>? Find(T value)
        {
            LinkedListNode<T> current = head;

            while (current != null)
            {
                if (current.Value != null)
                {
                    if (current.Value.Equals(value))
                        return current;
                }
                else
                {
                    if (value == null)
                        return current;
                }

                current = current.Next;
            }

            return null;
        }

        public LinkedListNode<T>? FindLast(T value)
        {
            LinkedListNode<T> current = head;
            LinkedListNode<T> entry = null;

            while (current != null)
            {
                if (current.Value != null)
                {
                    if (current.Value.Equals(value))
                        entry = current;
                }
                else
                {
                    if(value == null)
                        entry = current;
                }

                current = current.Next;
            }

            return entry;
        }

        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        }
    }

    internal sealed class LinkedListNode<T>
    {
        public T? Value { get; set; }

        public LinkedListNode<T>? Next { get; set; }

        public LinkedListNode() { }

        public LinkedListNode(T? value) { this.Value = value; }

        public override string ToString() => $"{Value}";
    }
    #endregion

    #region Doubly Linked List
    internal sealed class DoublyLinkedList<T>
    {
        private DoublyLinkedListNode<T> head;
        private DoublyLinkedListNode<T> tail;

        private int count;

        public int Count { get => count;}

        public DoublyLinkedListNode<T> First { get => head; }
        public DoublyLinkedListNode<T> Last { get => tail; }

        public DoublyLinkedListNode<T> AddFirst(T item)
        {
            DoublyLinkedListNode<T> newNode = new DoublyLinkedListNode<T>(item);

            if (head == null)
                head = tail = newNode;
            else
            {
                newNode.Next = head;
                head.Previous = newNode;
                head = newNode;
            }

            ++count;
            return newNode;
        }

        public void AddFirst(DoublyLinkedListNode<T> node)
        {
            if (head == null)
                head = tail = node;
            else
            {
                node.Next = head;
                head.Previous = node;
                head = node;
            }

            ++count;
        }

        public DoublyLinkedListNode<T> AddLast(T item)
        {
            DoublyLinkedListNode<T> newNode = new DoublyLinkedListNode<T>(item);

            if (head == null)
                head = tail = newNode;
            else
            {
                tail.Next = newNode;
                newNode.Previous = tail;
                tail = newNode;
            }

            ++count;
            return newNode;
        }

        public void AddLast(DoublyLinkedListNode<T> node)
        {
            if (head == null)
                head = tail = node;
            else
            {
                tail.Next = node;
                node.Previous = tail;
                tail = node;
            }

            ++count;
        }

        public DoublyLinkedListNode<T> AddAfter(DoublyLinkedListNode<T> node, T item)
        {
            if (this.count > 0)
            {
                DoublyLinkedListNode<T> newNode = new DoublyLinkedListNode<T>(item);

                if (node.Equals(tail))
                {
                    this.AddLast(newNode);
                    return newNode;
                }

                DoublyLinkedListNode<T> current = head;

                for (int i = 0, length = count - 1; i < length; ++i)
                {
                    if (current.Equals(node))
                    {
                        newNode.Next = current.Next;
                        current.Next.Previous = newNode;
                        current.Next = newNode;
                        newNode.Previous = current;

                        ++count;
                        return newNode;
                    }

                    current = current.Next;
                }

                throw new System.InvalidOperationException($"{nameof(node)} does not exist.");
            }
            else
                throw new System.InvalidOperationException($"{nameof(DoublyLinkedList<T>)} is empty.");
        }

        public void AddAfter(DoublyLinkedListNode<T> node, DoublyLinkedListNode<T> newNode)
        {
            if (count > 0)
            {
                if (tail.Equals(node))
                    this.AddLast(newNode);

                DoublyLinkedListNode<T> current = head;

                for (int i = 0, length = count - 1; i < length; ++i)
                {
                    if(current.Equals(node))
                    {
                        newNode.Next = current.Next;
                        current.Next.Previous = newNode;
                        newNode.Previous = current;
                        current.Next = newNode;

                        ++count;
                        return;
                    }

                    current = current.Next; 
                }

                throw new System.InvalidOperationException($"{nameof(node)} does not exist.");
            }
            else
                throw new System.InvalidOperationException($"{nameof(DoublyLinkedList<T>)} is empty.");
        }
        
        public void RemoveFirst()
        {
            if (count > 0)
            {
                head = head.Next;

                if (head == null)
                    tail = null;
                else
                    head.Previous = null;

                --count;
            }
            else
                throw new System.InvalidOperationException($"{nameof(DoublyLinkedList<T>)} is empty.");
        }

        public void RemoveLast()
        {
            if (count > 0)
            {
                tail = tail.Previous;

                if (tail == null)
                    head = null;

                --count;
            }
            else
                throw new System.InvalidOperationException($"{nameof(DoublyLinkedList<T>)} is empty.");
        }

        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        }
    }

    internal sealed class DoublyLinkedListNode<T>
    {
        public DoublyLinkedListNode<T> Previous { get; set; }

        public DoublyLinkedListNode<T> Next { get; set; }

        public T Value { get; set; }

        public DoublyLinkedListNode() { }

        public DoublyLinkedListNode(T value) { this.Value = value; }
    }
    #endregion

    #region Circular Linked List
    internal sealed class CircularLinkedList<T>
    {
        private CircularLinkedListNode<T>? head;
        private CircularLinkedListNode<T>? tail;

        private int count;

        public CircularLinkedListNode<T> First 
        { 
            get
            {
                if (count == 0)
                    throw new System.InvalidOperationException($"{nameof(CircularLinkedList<T>)} is empty.");

                return head;
            }
        }
        public CircularLinkedListNode<T> Last 
        { 
            get
            {
                if (count == 0)
                    throw new System.InvalidOperationException($"{nameof(CircularLinkedList<T>)} is empty.");

                return tail;
            }
        }

        public int Count { get => count; }

        public CircularLinkedList() { }

        public CircularLinkedList(params T[] items)
        {
            for (int i = 0,length = items.Length; i < length; ++i)
                this.AddLast(items[i]);
        }

        public CircularLinkedListNode<T> AddFirst(T item)
        {
            CircularLinkedListNode<T> newNode = new CircularLinkedListNode<T>(item);

            if (head == null)
                head = tail = newNode;
            else
            {
                newNode.Next = head;
                head = newNode;
                tail.Next = newNode;
            }

            ++count;
            return newNode;
        }

        public void AddFirst(CircularLinkedListNode<T> node)
        {
            if (node == null)
                throw new System.ArgumentNullException($"{nameof(node)} is null.");

            if (head == null)
                head = tail = node;
            else
            {
                node.Next = head;
                head = node;
                tail.Next = head;
            }

            ++count;
        }

        public CircularLinkedListNode<T> AddLast(T item)
        {
            CircularLinkedListNode<T> newNode = new CircularLinkedListNode<T>(item);

            if (head == null)
                head = tail = newNode;
            else
            {
                tail.Next = newNode;
                newNode.Next = head;
                tail = newNode;
            }

            ++count;
            return newNode;
        }

        public void AddLast(CircularLinkedListNode<T> node)
        {
            if (node == null)
                throw new System.ArgumentNullException($"{nameof(node)} is null.");

            if (head == null)
                head = tail = node;
            else
            {
                tail.Next = node;
                node.Next = head;
            }

            ++count;
        }

        //public void RemoveFirst()       //Fix this shit
        //{

        //}

        //public void RemoveLast()
        //{

        //}

        public bool Remove(CircularLinkedListNode<T> item)
        {
            if(count != 0 && item != null)
            {
                CircularLinkedListNode<T> current = head, previous = head;

                for (int i = 0, length = count; i < length; ++i)
                {
                    if (current.Equals(item))
                    {
                        previous = current.Next;
                        --count;
                        return true;
                    }

                    previous = current;
                    current = current.Next;
                }
            }

            return false;
        }

        public bool Remove(T item)
        {
            if (count != 0)
            {
                CircularLinkedListNode<T> current = head, previous = head;

                for (int i = 0, length = count; i < length; ++i)
                {
                    if(current.Value.Equals(item))
                    {
                        previous = current.Next;
                        --count;
                        return true;
                    }

                    previous = current;
                    current = current.Next;
                }
            }

            return false;
        }

        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        }
    }

    internal sealed class CircularLinkedListNode<T>
    {
        public T? Value { get; set; }
        public CircularLinkedListNode<T>? Next { get; set; }

        public CircularLinkedListNode() { }

        public CircularLinkedListNode(T value) { this.Value = value; }
    }
    #endregion

    #region Circular Doubly Linked List
    internal sealed class CircularDoublyLinkedList<T>
    {

    }

    internal sealed class CircularDoublyLinkedListNode<T>
    {

    }
    #endregion

    #region Hash Table
    #endregion

    #region Dictionary
    #endregion

    #region Associative Array
    #endregion

    #region Stack
    internal sealed class Stack<T>
    {
        private StackNode<T> stack;

        private int count;

        public int Count { get => count; }

        public Stack() { }

        public Stack(T item) => this.Push(item);

        public Stack(params T[] items)
        {
            foreach (T item in items)
                this.Push(item);
        }

        public void Push(T item)
        {
            StackNode<T> newNode = new StackNode<T>(item);

            if (stack == null)
                stack = newNode;
            else
            {
                newNode.Previous = stack;
                stack = newNode;
            }

            ++count;
        }

        public T Peek()
        {
            if(stack != null)
                return stack.Value;
            else
                throw new System.InvalidOperationException($"The {nameof(DataStructures.Stack<T>)} is empty.");
        }

        public bool TryPeek(out T result)
        {
            if (stack != null)
            {
                result = stack.Value;
                return true;
            }
            else
            {
                result = default;
                return false;
            }
        }

        public T Pop()
        {
            if (stack != null)
            {
                T item = stack.Value;
                stack = stack.Previous;
                --count;
                return item;
            }
            else
                throw new System.InvalidOperationException($"The {nameof(DataStructures.Stack<T>)} is empty.");
        }

        public bool TryPop(out T result)
        {
            if (stack != null)
            {
                result = stack.Value;
                stack = stack.Previous;
                --count;
                return true;
            }
            else
            {
                result = default;
                return false;
            }
        }

        public bool Contains(T item)
        {
            StackNode<T> current = stack;

            while (current != null)
            {
                if (current.Value != null)
                {
                    if (current.Value.Equals(item))
                        return true;
                }
                else
                {
                    if (item == null)
                        return true;
                }

                current = current.Previous;
            }

            return false;
        }

        public void Clear()
        {
            stack = null;
            count = 0;
        }

        private sealed class StackNode<T>
        {
            public T Value { get; set; }

            public StackNode<T> Previous { get; set; }

            public StackNode() { }

            public StackNode(T value) { this.Value = value; }
        }
    }
    #endregion

    #region Queue
    internal sealed class Queue<T>
    {
        private QueueNode<T> queue;
        private QueueNode<T> tail;

        private int count;
        public int Count { get => count; }

        public void Enqueue(T item)
        {
            QueueNode<T> newItem = new QueueNode<T>(item);

            if (queue == null)
                queue = tail = newItem;
            else
            {
                tail.Next = newItem;
                tail = newItem;
            }

            ++count;
        }

        public T Dequeue()
        {
            if (queue != null)
            {
                T item = queue.Value;
                queue = queue.Next;
                --count;
                return item;
            }
            else
                throw new InvalidOperationException($"{nameof(DataStructures.Queue<T>)} is empty.");
        }

        public bool TryDequeue(out T result)
        {
            if (queue != null)
            {
                result = queue.Value;
                queue = queue.Next;
                --count;
                return true;
            }
            else
            {
                result = default;
                return false;
            }
        }

        public T Peek()
        {
            if (queue != null)
                return queue.Value;
            else
                throw new InvalidOperationException($"{nameof(DataStructures.Queue<T>)} is empty.");
        }

        public bool TryPeek(out T result)
        {
            if (queue != null)
            {
                result = queue.Value;
                return true;
            }
            else
            {
                result = default;
                return false;
            }
        }

        public bool Contains(T item)
        {
            QueueNode<T> current = queue;

            while (current != null)
            {
                if (current.Value != null)
                {
                    if (current.Value.Equals(item))
                        return true;
                }
                else
                {
                    if (item == null)
                        return true;
                }

                current = current.Next;
            }

            return false;
        }

        public void Clear()
        {
            queue = null;
            tail = null;
            count = 0;
        }

        private sealed class QueueNode<T>
        {
            public T Value { get; set; }
            public QueueNode<T> Next { get; set; }

            public QueueNode() { }

            public QueueNode(T value) { this.Value = value; }  
        }
    }
    #endregion

    #region Deque
    internal sealed class Deque<T>
    {
        private DequeNode<T> head;
        private DequeNode<T> tail;

        private int count;

        public int Count { get => count; }

        public bool IsEmpty { get { return count < 1 ? true : false; } }

        public Deque() { }

        public Deque(params T[] items)
        {
            for (int i = 0, length = items.Length; i < length; ++i)
                this.PushBack(items[i]);
        }

        public void PushBack(T item)
        {
            DequeNode<T> newNode = new DequeNode<T>(item);

            if (head == null)
                head = tail = newNode;
            else
            {
                tail.Next = newNode;
                newNode.Previous = tail;
                tail = newNode;
            }

            ++count;
        }

        public void PushFront(T item)
        {
            DequeNode<T> newNode = new DequeNode<T>(item);

            if (head == null)
                head = tail = newNode;
            else
            {
                head.Previous = newNode;
                newNode.Next = head;
                head = newNode;
            }

            ++count;
        }

        public T PopBack()
        {
            if (count < 1)
                throw new System.InvalidOperationException($"{nameof(Deque<T>)} is empty. ");

            T item = tail.Value;
            tail = tail.Previous;

            if (tail == null)
                head = null;

            --count;
            return item;
        }           //Has to be improved

        public T PopFront()
        {
            if (count < 1)
                throw new System.InvalidOperationException($"{nameof(Deque<T>)} is empty.");

            T item = head.Value;
            head = head.Next;

            if (head == null)
                tail = null;

            --count;
            return item;
        }           //Has to be improved

        public bool TryPopBack(out T result)
        {
            if (count > 0)
            {
                result = tail.Value;
                tail = tail.Previous;

                if (tail == null)
                    head = null;
                else
                    tail.Previous.Next = null;

                --count;
                return true;
            }
            else
            {
                result = default(T);
                return false;
            }
        }       //Has to be improved

        public bool TryPopFront(out T result)
        {
            if (count > 0)
            {
                result = head.Value;
                head = head.Next;

                if (head == null)
                    tail = null;
                else
                    head.Previous = null;

                --count;
                return true;
            }
            else
            {
                result = default(T);
                return false;
            }
        }       //Has to be improved

        public T PeekBack() => count < 1 ? throw new System.InvalidOperationException($"{nameof(Deque<T>)} is empty.") : tail.Value;

        public T PeekFront() => count < 1 ? throw new System.InvalidOperationException($"{nameof(Deque<T>)} is empty.") : head.Value;

        public bool TryPeekBack(out T result)
        {
            if (count > 0)
            {
                result = tail.Value;
                return true;
            }
            else
            {
                result = default(T);
                return false;
            }
        }

        public bool TryPeekFront(out T result)
        {
            if (count > 0)
            {
                result = head.Value;
                return true;
            }
            else
            {
                result = default(T);
                return false;
            }
        }

        public bool Contains(T item)
        {
            DequeNode<T> current = head;

            while (current != null)
            {
                if (current.Value != null)
                {
                    if(current.Value.Equals(item))
                        return true;
                }
                else
                {
                    if (item == null)
                        return true;
                }

                current = current.Next;
            }

            return false;
        }

        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        }

        private sealed class DequeNode<T>
        {
            public DequeNode<T> Previous { get; set; }

            public DequeNode<T> Next { get; set; }

            public T Value { get; set; }

            public DequeNode() { }

            public DequeNode(T value) { this.Value = value; }
        }
    }
    #endregion
}