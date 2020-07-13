using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace ConsoleApp2
{
    internal class Stack
    {
        static readonly int MAX = 1000;
        int top;
        int[] stack = new int[MAX];

        bool IsEmpty()
        {
            return (top < 0);
        }
        public Stack()
        {
            top = -1;
        }
        internal bool Push(int data)
        {
            if (top >= MAX)
            {
                Console.WriteLine("Stack Overflow");
                return false;
            }
            else
            {
                stack[++top] = data;
                return true;
            }
        }

        internal int Pop()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return 0;
            }
            else
            {
                int value = stack[top--];
                return value;
            }
        }
        public unsafe class Node
        {
            public char Character { get; set; }
            public int Frequency { get; set; }
            public Node left;
            public Node right;
            public Node Parent;
        }
        public unsafe class Tree
        {
            public Node root;
            public Tree()
            {

                root = null;
                root.left = null;
                root.right = null;
                root.Parent = null;

            }
        }
        class Class1
        {
            public static void Huffman_Tree(int[] Frequency, char[] Character)
            {
                Node node_HT = new Node();

                Stack for_freq = new Stack();
                Stack for_ch = new Stack();
                for (int i = 0; i < Frequency.Length; i++)
                {
                    for_freq.Push(i);
                    for_ch.Push(i);
                }
                Node node1 = new Node();
                Node node2 = new Node();
                Node node3 = new Node();

                for (int j = 0; j < Frequency.Length; j++)
                {



                    if (node_HT == null)
                    {

                        node1.Frequency = Frequency[j] + Frequency[j + 1];
                        node2.Frequency = Frequency[j];
                        node3.Frequency = Frequency[j + 1];
                        node1.right = node2;
                        node1.left = node3;
                        node_HT = node1;
                    }
                    else
                    {

                        int f1 = 0;
                        int f2 = 0;
                        Stack<int> fq = new Stack<int>();
                        f1 = for_freq.Pop();
                        f2 = for_freq.Pop();
                        Console.WriteLine(f1);
                        fq.Push(f1 + f2);
                        Node temp = new Node();
                        int sum = Frequency[j] + Frequency[j + 1];
                        if (sum > node1.Parent.Frequency && node1.Parent.Frequency < Frequency[j + 1])
                        {
                            temp.left = node1.Parent;
                            temp.right = node1;
                            node1.Parent = temp;
                            char chara = Character[j + 1];

                        }
                        else
                        {
                            temp.right = node1.Parent;
                            temp.left = node1;
                            node1.Parent = temp;
                            char chara = Character[j + 1];

                        }

                    }


                }

            }
            public static void sort_in_reverse(int[] freq, char[] ch)
            {
                int n = freq.Length;

                // One by one move boundary of unsorted subarray
                for (int i = n - 1; i > 0; i--)
                {
                    // Find the minimum element in unsorted array
                    int max_idx = i;
                    int ch_idx = i;
                    for (int j = i - 1; j >= 0; j--)
                        if (freq[j] < freq[max_idx])
                        {
                            max_idx = j;
                            ch_idx = j;
                        }


                    // Swap the found minimum element with the first
                    // element
                    int temp1 = freq[max_idx];
                    char temp2 = ch[max_idx];
                    freq[max_idx] = freq[i];
                    ch[max_idx] = ch[i];
                    freq[i] = temp1;
                    ch[i] = temp2;

                }
                //Console.ReadLine();

            }


            static void Main(string[] args)
            {
                int[] freq = { 1, 2, 3, 4, 5 };
                char[] ch = { 'a', 'b', 'c', 'd', 'e' };
                sort_in_reverse(freq, ch);
                for (int i = 0; i < freq.Length; i++)
                {
                    Console.Write(freq[i]);
                }
                Console.WriteLine();
                for (int i = 0; i < ch.Length; i++)
                {
                    Console.Write(ch[i]);
                }

                Huffman_Tree(freq, ch);
                Console.ReadLine();
            }
        }

    }
}