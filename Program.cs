using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace ConsoleApp2
{

    public unsafe class Node
    {
        public char Character { get; set; }
        public int Frequency { get; set; }
        public Node left;
        public Node right;
        // public Node Parent;
    }
    public unsafe class Tree
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
        public static void Huffman_Tree(int[] Frequency, char[] Character)
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
                    // Code1 += "1";

                    Code2 = Code1;
                    Code2 += "1";
                    if (n4.left != null)
                    {
                        Flag = false;
                        n4 = n4.left;
                    }
                }
                if (n4.left == null && n4.right == null && n5.left == null && n5.right == null)
                {
                    Code1 += "0";
                    Code += Code1 + "," + Convert.ToString(n4.Frequency) + "," + n4.Character + "\n";
                    Code_arr[counter++] = Code;
                    Code = "";
                    Flag = true;
                }
                if (n5.left == null && n5.right == null)
                {
                    Code2 += "1";
                    Code += Code2 + "," + Convert.ToString(n5.Frequency) + "," + n5.Character + "\n";
                    Code_arr[counter++] = Code;
                    Code = "";
                    // break;
                }
            }

            File.WriteAllText("CSF.txt", "");
            for (int j = 0; j < Code_arr.Length; j++)
            {
                File.AppendAllText("CSF.txt", Code_arr[j]);
            }
            Encode();
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
        public static void Encode()
        {
            string R = "", Line = "";
            string s = File.ReadAllText("test.txt");
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
        public static void Decompress()
        {
            Node LeafNode = new Node();
            string[] m = File.ReadAllLines("CSF.txt");
            string d = File.ReadAllText("CF.txt");
            int[] Frequency = new int[m.Length];
            char[] Character = new char[m.Length];
            int a = 0;
            string f = "";
            int k = 0;
            bool flag = false;
            for (int j = 0; j < m.Length; j++)
            {
                k = 0;
                if (m[j].Length > 1)
                {
                    if (m[j][m[j].Length - 1] == ',' && m[j][m[j].Length - 2] != ',')
                        Character[a] = '\n';
                    else
                    {
                        Character[a] = (m[j][m[j].Length - 1]);
                    }

                    while (k < m[j].Length || flag)
                    {
                        if (m[j][k] == ',' && flag == false)
                        {
                            flag = true;
                        }
                        k++;

                        if (flag)
                        {

                            f += m[j][k];

                            if (m[j][k + 1] == ',' && flag == true)
                            {
                                flag = false;

                                break;
                            }
                        }

                    }

                    Int32.TryParse(f, out Frequency[a++]);
                    f = "";

                }

            }

            Array.Reverse(Character);
            Array.Reverse(Frequency);
            // sort_in_order(Frequency, Character);
            char tempc = Character[0];
            Character[0] = Character[1];
            Character[1] = tempc;

            int tempf = Frequency[0];
            Frequency[0] = Frequency[1];
            Frequency[1] = tempf;
            /*-------------------------------------- */
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
            
            string T = "";
            Node Root = new Node();
            Node tptr = parent;
            Node temp1 = new Node();
            string F = File.ReadAllText("CF.txt");
            var b = File.Create("Decode.txt");
            b.Close();

            foreach (char c in F)
            {
                if (c == '1')
                {
                    tptr = tptr.right;
                }
                else
                {
                    tptr = tptr.left;
                }
                if (tptr.left == null)
                {
                    T += tptr.Character.ToString();
                    tptr = parent;
                }
            }
            File.WriteAllText("Decode.txt", T);
        }

        static void Main(string[] args)
        {

            // Array to store frequencies.
            int[] c = new int[(int)char.MaxValue];

            // Read entire text file.
            string s = File.ReadAllText("test.txt");
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

            Huffman_Tree(freq, ch);
            // Encode();
            Decompress();

            Console.WriteLine("Press any key to exit......");
            Console.ReadLine();
        }
    }

}