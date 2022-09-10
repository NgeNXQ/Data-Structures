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
}
