using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// Stretch Goals: Using Generics, which would include implementing GetType() http://msdn.microsoft.com/en-us/library/system.object.gettype(v=vs.110).aspx
namespace SinglyLinkedLists
{
    public class SinglyLinkedListNode : IComparable
    {
        // Used by the visualizer.  Do not change.
        public static List<SinglyLinkedListNode> allNodes = new List<SinglyLinkedListNode>();
        //Getter and Setter for next on node in SLL
        // READ: http://msdn.microsoft.com/en-us/library/aa287786(v=vs.71).aspx
        private SinglyLinkedListNode next;
        public SinglyLinkedListNode Next
        { 
            get { return next; }

            set
            {
                if (this == value)
                {
                    throw new ArgumentException();
                }

                this.next = value;

            }
        }
        //Gets the value on node in SLL
        private string value;
        public string Value 
        {
            get { return value; }
        }
        
        public static bool operator <(SinglyLinkedListNode node1, SinglyLinkedListNode node2)
        {
            // This implementation is provided for your convenience.
            return node1.CompareTo(node2) < 0;
        }

        public static bool operator >(SinglyLinkedListNode node1, SinglyLinkedListNode node2)
        {
            // This implementation is provided for your convenience.
            return node1.CompareTo(node2) > 0;
        }
        //Constructor for A Node Needs value and next Intializes node
        public SinglyLinkedListNode(string value)
        {
            this.value = value;


            this.value = value;
            // Used by the visualizer:
            allNodes.Add(this);
        }
        //determines which node shows up first
        // READ: http://msdn.microsoft.com/en-us/library/system.icomparable.compareto.aspx
        public int CompareTo(Object obj)
        {
            if (obj == null) return 1;

            SinglyLinkedListNode otherNode = obj as SinglyLinkedListNode;
            if (otherNode != null)
                return this.Value.CompareTo(otherNode.Value);
            else
                throw new ArgumentException("Object Value was null");
        }
        //Returns if Node Value is the Last Value in SLL
        public bool IsLast()
        {
            return (Next == null);
        }

        public override string ToString()
        {
            return Value;
        }

        public override bool Equals(object obj)
        {
            if (obj is SinglyLinkedListNode)
            {
                SinglyLinkedListNode node = obj as SinglyLinkedListNode;
                return Equals(this.Value, node.Value);
            }
            else
            {
                return false;
            }
        }
    }
}
