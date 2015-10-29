using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SinglyLinkedLists
{
    public class SinglyLinkedList
    {
        private SinglyLinkedListNode first;
       
        //List Constructor: Needs a first node. 
        // READ: http://msdn.microsoft.com/en-us/library/aa691335(v=vs.71).aspx
        public SinglyLinkedList(params object[] values)
        {
            first = new SinglyLinkedListNode(null);
        }

        //UNKNOWN TERRITORY
        // READ: http://msdn.microsoft.com/en-us/library/6x16t2tx.aspx
        public string this[int i]
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        // Adds A Node Value after Specified Existing Node Value in the SLL
        public void AddAfter(string existingValue, string value)
        {
            throw new NotImplementedException();
        }
        //Adds A Node to the beginning of to SLL
        public void AddFirst(string value)
        {
            SinglyLinkedListNode  node = first;
            if (node.Value == null)
            {
                first = new SinglyLinkedListNode(value);
            }
            else
            {
               
            }
        }
        //Adds a Node Value to the end of the SLL
        public void AddLast(string value)
        {
            SinglyLinkedListNode node = first;
            if (first.Value == null)
            {
                first = new SinglyLinkedListNode(value);
            }
            while (!node.IsLast())
            {
                node = node.Next;
            }
            node.Next = new SinglyLinkedListNode(value);
        }

        // NOTE: There is more than one way to accomplish this.  One is O(n).  The other is O(1). Counts the Node Values in SLL
        public int Count()
        {
            throw new NotImplementedException();
        }
        //Finds an element at index based on UNKNOW TERRITORY
        public string ElementAt(int index)
        {
            if (this.First() == null)
            {
                throw new ArgumentOutOfRangeException();
            }
            SinglyLinkedListNode node = first;
            for (int i = 0; i <= index; i++)
            {
                if (i == index)
                {
                    break;
                }
                else
                {
                    if (node.Next == null)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    node = node.Next;
                }
            }
            return node.Value;
        }
        //Returns First Node Value in SLL
        public string First()
        {
            return first.Value;
        }
        //Finds the index of a Specifice Node Value in SLL
        public int IndexOf(string value)
        {
            throw new NotImplementedException();
        }
        //Determines if SLL is in Alphabetical order
        public bool IsSorted()
        {
            throw new NotImplementedException();
        }
        //Returns the last Node Follow Hints
        // HINT 1: You can extract this functionality (finding the last item in the list) from a method you've already written!
        // HINT 2: I suggest writing a private helper method LastNode()
        // HINT 3: If you highlight code and right click, you can use the refactor menu to extract a method for you...
        public string Last()
        {
            SinglyLinkedListNode node = first;
            if (node.Value == null)
            {
                return null;
            }
            else
            {
                while (!node.IsLast())
                {
                    node = node.Next;
                }
                return node.Value;
            }
        }
        //Removes Specified Node Value in SLL
        public void Remove(string value)
        {
            throw new NotImplementedException();
        }
        //Puts Items in alphabetical or numerical order
        public void Sort()
        {
            throw new NotImplementedException();
        }
        //Changes SLL into a fixed sized array
        public string[] ToArray()
        {
            List<string> results = new List<string>();
            SinglyLinkedListNode node = first;
            if (First() == null)
            {
                return new string[] { };
            }
            else
            {
                while (node != null)
                {
                    results.Add(node.Value);
                    node = node.Next;
                }
                return results.ToArray();
            }
        }

        public override string ToString()
        {
            if (first.Value == null)
            {
                return "{ }";
            }
            else
            {
                SinglyLinkedListNode node = first;
                string result = "{ ";
                while (node != null)
                {
                    if (node.Next == null)
                    {
                        result += "\"" + node.Value + "\" ";
                    }
                    else
                    {
                        result += "\"" + node.Value + "\", ";
                    }
                    node = node.Next;
                }
                result += "}";
                return result;
            }
        }
    }
}
