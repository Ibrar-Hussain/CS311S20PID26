using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace Project_UI
{

    public class Node
    {
        public char Character { get; set; }
        public int Frequency { get; set; }
        public Node left;
        public Node right;
        // public Node Parent;
    }
    public class Tree
    {
        public Node root;
        public Tree()
        {

            root = null;
            root.left = null;
            root.right = null;
            // root.Parent = null;


        }
    }
    class Class1
    {
        public static void Huffman_Tree(int[] Frequency, char[] Character, string path)
        {

            Node n1 = new Node();
            Node parent;
            parent = n1;
            parent.Frequency = 0;
            parent.left = null; parent.right = null;
            for (int i = 0; i < Frequency.Length; i++)
            {
                if (parent.Frequency == 0)
                {
                    Node n2 = new Node();
                    Node n3 = new Node();
                    n2.Frequency = Frequency[0]; n2.Character = Character[0];
                    n3.Frequency = Frequency[1]; n3.Character = Character[1];
                    parent.Frequency = n2.Frequency + n3.Frequency;
                    parent.right = n3;
                    parent.left = n2;
                    i++;
                }
                else
                {

                    Node temp = new Node();
                    temp.Frequency = Frequency[i] + parent.Frequency;
                    temp.Character = '\0';
                    if (temp.Frequency > parent.Frequency && parent.Frequency < Frequency[i])
                    {
                        Node next = new Node(); next.Frequency = Frequency[i]; next.Character = Character[i];
                        temp.left = parent;
                        temp.right = next;
                        parent = temp;
                    }
                    else
                    {
                        Node next = new Node(); next.Frequency = Frequency[i]; next.Character = Character[i];
                        temp.right = parent;
                        temp.left = next;
                        parent = temp;
                    }

                }
            }
            string Code = "",
            Code1 = "",
            Code2 = "";
            string[] Code_arr = new string[Character.Length];
            int counter = 0;
            bool Flag = false;
            Node n4, n5;
            Node Temp = parent;
            n4 = Temp.left;
            n5 = Temp.right;
            Code2 = "1";
            while ((n5.left != null && n5.right != null))
            {

                if (Flag == false && n4.left == null && n4.right == null)
                {
                    Code1 += "0";
                    if (n4.left == null && n4.right == null)
                    {
                        Code += Code1 + "," + Convert.ToString(n4.Frequency) + "," + n4.Character + "\n";
                        Code_arr[counter++] = Code;
                        Code = "";
                        Flag = true;
                        //Code = "";

                    }
                }
                if (Flag == true && n5.left != null && n5.right != null)
                {
                    Code1 = Code2;
                    n4 = n5;
                    n5 = n5.right;
                    // n4 = n5;
                    Code1 += "1";
                    Code2 = Code1;
                    if (n4.left != null)
                    {
                        Flag = false;
                        n4 = n4.left;
                    }
                }
                if (n5.left == null && n5.right == null)
                {
                    Code += Code2 + "," + Convert.ToString(n5.Frequency) + "," + n5.Character + "\n";
                    Code_arr[counter++] = Code;
                    Code = "";
                    // break;
                }
            }
            if (n4.left == null && n4.right == null)
            {
                Code += Code1 + "," + Convert.ToString(n4.Frequency) + "," + n4.Character + "\n";
                Code_arr[counter++] = Code;
                Code = "";
            }
            File.WriteAllText("CSF.txt", "");
            for (int j = 0; j < Code_arr.Length; j++)
            {
                File.AppendAllText("CSF.txt", Code_arr[j]);
            }
            Encode(path);
        }

        public static void sort_in_order(int[] freq, char[] ch)
        {
            int n = freq.Length;

            // One by one move boundary of unsorted subarray
            for (int i = 0; i < n - 1; i++)
            {
                // Find the minimum element in unsorted array
                int min_idx = i;
                int ch_idx = i;
                for (int j = i + 1; j < n; j++)
                    if (freq[j] < freq[min_idx])
                    {
                        min_idx = j;
                        ch_idx = j;
                    }


                // Swap the found minimum element with the first
                // element
                int temp1 = freq[min_idx];
                char temp2 = ch[min_idx];
                freq[min_idx] = freq[i];
                ch[min_idx] = ch[i];
                freq[i] = temp1;
                ch[i] = temp2;

            }
            //Console.ReadLine();

        }
        public static void Encode(string path)
        {
            string R = "", Line = "";
            string s = File.ReadAllText(path);
            string[] c = File.ReadAllLines("CSF.txt");
            File.WriteAllText("CF.txt", "");
            foreach (char chara in s)
            {
                for (int i = 0; i < c.Length; i++)
                {
                    //int l = 0;
                    if (c[i].Length == 0)
                    {
                        continue;
                    }
                    else if (c[i].Length > 1)
                    {
                        Line = c[i];
                        if (Char.Equals(Line[Line.Length - 1], chara) == true)
                        {
                            int j = 0;
                            while (Line[j] != ',')
                            {
                                R += Line[j];
                                j++;
                            }
                            break;
                        }
                    }

                }
                File.AppendAllText("CF.txt", R);
                R = "";

            }

        }



        public static void Start(string path)
        {



            // Array to store frequencies.
            int[] c = new int[(int)char.MaxValue];



            // Read entire text file.
            string s = File.ReadAllText(path);
            // Iterate over each character.
            int length = 0;
            foreach (char t in s)
            {
                // Increment table.
                if (c[(int)t] == '\0')
                    length++;
                c[(int)t]++;
            }



            int[] freq = new int[length];
            char[] ch = new char[length];



            int k = 0;
            // Write all letters found.
            for (int i = 0; i < (int)char.MaxValue; i++)
            {
                if (c[i] > 0)
                {
                    ch[k] = (char)i;
                    freq[k++] = c[i];
                }
            }



            sort_in_order(freq, ch);



            Huffman_Tree(freq, ch,path);
            Encode(path);



            Console.ReadLine();



            Console.WriteLine("Press any key to exit......");
            Console.ReadLine();
        }
    }



}