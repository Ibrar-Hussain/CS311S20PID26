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
        public static void H_Tree(int[] Frequency, char[] Character,string path)
        {
            Node n1 = new Node();
            Node parent;   //pointer
            parent = n1;
            parent.Frequency = 0;
            parent.left = null;
            parent.right = null;
            for (int i = 0; i < Frequency.Length; i++)
            {
                if (parent.Frequency == 0)
                {
                    Node n2 = new Node();
                    Node n3 = new Node();
                    n2.Frequency = Frequency[0];
                    n2.Character = Character[0];
                    n3.Frequency = Frequency[1];
                    n3.Character = Character[1];
                    parent.Frequency = n2.Frequency + n3.Frequency;
                    parent.right = n2;
                    parent.left = n3;
                    i++;
                }
                else
                {
                    Node temp = new Node();
                    temp.Frequency = Frequency[i] + parent.Frequency;
                    temp.Character = '\0';
                    Node next = new Node();
                    next.Frequency = Frequency[i];
                    next.Character = Character[i];
                    temp.right = parent;
                    temp.left = next;
                    parent = temp;
              
                }
            }
            string Code = "",
            Code1 = "",
            Code2 = "";
            string[] Code_arr = new string[Character.Length];  //dymaic array
            int counter = 0;
            bool Flag = false;
            Node n4, n5;
            Node Temp = parent;
            n4 = Temp.left;
            n5 = Temp.right;
            Code2 = "1";
            if (n4.left == null && n4.right == null && n5.left == null && n5.right == null) //left leaf node
            {
                Code1 += "0";
                Code += Code1 + "," + Convert.ToString(n4.Frequency) + "," + n4.Character + "\n";
                Code_arr[counter++] = Code;
                Code = "";
                Flag = true;
            }
            if (n5.left == null && n5.right == null)   //right leaf node
            {
                Code += Code2 + "," + Convert.ToString(n5.Frequency) + "," + n5.Character;
                Code_arr[counter++] = Code;
                Code = "";
            }
            while ((n5.left != null && n5.right != null))    //leaf node
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
                        Code = "";
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
                if (n4.left == null && n4.right == null && n5.left == null && n5.right == null) //left leaf node
                {
                    Code1 += "0";
                    Code += Code1 + "," + Convert.ToString(n4.Frequency) + "," + n4.Character + "\n";
                    Code_arr[counter++] = Code;
                    Code = "";
                    Flag = true;
                }
                if (n5.left == null && n5.right == null)   //right leaf node
                {
                    //Code2 += "1";
                    Code += Code2 + "," + Convert.ToString(n5.Frequency) + "," + n5.Character;
                    Code_arr[counter++] = Code;
                    Code = "";
                }
            }
            File.WriteAllText("C:\\Users\\Public\\Documents\\CSF.txt", "");    // file null
            for (int j = 0; j < Code_arr.Length; j++)
            {
                File.AppendAllText("C:\\Users\\Public\\Documents\\CSF.txt", Code_arr[j]);
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
            string[] c = File.ReadAllLines("C:\\Users\\Public\\Documents\\CSF.txt");
            File.WriteAllText("C:\\Users\\Public\\Documents\\CF.txt", "");
            foreach (char chara in s)
            {
                for (int i = 0; i < c.Length; i++)
                {
                    if (chara == '\n' && c[i].Length == 0)
                    {
                        int j = 0;
                        Line = c[i - 1];
                        while (Line[j] != ',')
                        {
                            R += Line[j];
                            j++;
                        }
                        File.AppendAllText("C:\\Users\\Public\\Documents\\CF.txt", R);
                        R = "";
                        break;
                    }
                    else if (c[i].Length > 1)
                    {
                        Line = c[i];
                        if (Char.Equals(Line[Line.Length - 1], chara) == true)   //char.equals= to compare two charcters
                        {
                            if (Char.Equals(Line[Line.Length - 1], chara) && Line[Line.Length - 2] == ',')
                            {
                                int j = 0;
                                while (Line[j] != ',')
                                {
                                    R += Line[j];
                                    j++;
                                }
                                break;
                            }
                            else if (Char.Equals(Line[Line.Length - 1], chara) && Line[Line.Length - 2] != ',')
                            {
                                continue;
                            }
                            else
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

                }
                if (R.Length >= 30000)
                {
                    File.AppendAllText("C:\\Users\\Public\\Documents\\CF.txt", R);
                    R = "";
                }
            }
            File.AppendAllText("C:\\Users\\Public\\Documents\\CF.txt", R);
            R = "";
        }
        public static void Decompress(string path2,string path3)
        {
            Node LeafNode = new Node();
            string[] m = File.ReadAllLines(path3);
            string d = File.ReadAllText(path2);
            int[] Frequency = new int[m.Length];
            char[] Character = new char[m.Length];
            int a = 0;
            string f = "";
            int k = 0;
            bool flag = false;
            for (int j = 0; j < m.Length; j++)
            {
                k = 0;
                if (m[j].Length == 0)
                {
                    Character[a] = '\n';
                    while (k < m[j - 1].Length || flag)
                    {
                        if (m[j - 1][k] == ',' && flag == false)
                        {
                            flag = true;
                        }
                        k++;
                        if (flag)
                        {
                            f += m[j - 1][k];
                            if (m[j - 1][k + 1] == ',' && flag == true)
                            {
                                flag = false;
                                break;
                            }
                        }
                    }
                    Int32.TryParse(f, out Frequency[a++]);
                    Character[a] = '\r';
                    Int32.TryParse(f, out Frequency[a++]);
                    f = "";
                }
                else if (m[j].Length > 1)
                {
                    if (m[j][m[j].Length - 1] == ',' && m[j][m[j].Length - 2] != ',')
                        continue;
                    else
                    {
                        Character[a] = (m[j][m[j].Length - 1]);
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
            }

            Array.Reverse(Character);
            Array.Reverse(Frequency);
            bool is_null = false;
            if (Character[0] == '\0')
                is_null = true;

            Node n1 = new Node();
            Node parent;
            parent = n1;
            parent.Frequency = 0;
            parent.left = null; parent.right = null;
            int i;
            if (is_null)
                i = 1;
            else
                i = 0;
            for (; i < Frequency.Length; i++)
            {
                if (parent.Frequency == 0)
                {
                    Node n2 = new Node();
                    Node n3 = new Node();
                    n2.Frequency = Frequency[i];
                    n2.Character = Character[i];
                    n3.Frequency = Frequency[i + 1];
                    n3.Character = Character[i + 1];
                    parent.Frequency = n2.Frequency + n3.Frequency;
                    parent.right = n2;
                    parent.left = n3;
                    i++;
                }
                else
                {
                    Node temp = new Node();
                    temp.Frequency = Frequency[i] + parent.Frequency;
                    temp.Character = '\0';
                    if (parent.Frequency < Frequency[i])
                    {
                        Node next = new Node(); next.Frequency = Frequency[i]; next.Character = Character[i];
                        temp.left = next;
                        temp.right = parent;
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
            string F = File.ReadAllText(path2);
            var b = File.Create("C:\\Users\\Public\\Documents\\Decode.txt");
            b.Close();
            foreach (char c in F)
            {
                if (c == '1')
                {
                    tptr = tptr.right;
                    if (tptr.left == null && tptr.right == null)
                    {
                        T += tptr.Character.ToString();
                        tptr = parent;
                    }
                }
                else
                {
                    tptr = tptr.left;
                    if (tptr.left == null && tptr.right == null)
                    {
                        T += tptr.Character.ToString();
                        tptr = parent;
                    }
                }

            }
            File.WriteAllText("C:\\Users\\Public\\Documents\\Decode.txt", T);
        }


        public static void Start(string path)
        {



            // Array to store frequencies.
            int[] c = new int[(int)char.MaxValue];



            // Read entire text file.
            if (File.Exists(path))
            {
                Console.WriteLine("Specified file exists.");
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



                H_Tree(freq, ch, path);
                //Encode(path);

            }

            else
            {

                Console.WriteLine("Specified file does not " +

                          "exist in the current directory.");
            

            }



            Console.ReadLine();



            Console.WriteLine("Press any key to exit......");
            Console.ReadLine();
        }
        public static void End(string path2,string path3)
        {
            Decompress(path2, path3);
        }
    }



}
