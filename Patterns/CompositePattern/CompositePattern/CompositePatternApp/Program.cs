﻿using CompositePatternApp.Structural;
using Newtonsoft.Json;
using System;
using System.Xml.Linq;
using System.Linq;

namespace CompositePatternApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var xml = XElement.Load("file-system.xml");

            foreach (var leaf in xml.FindElements(x => !x.HasElements))
            {
                Console.WriteLine($"***** LEAF: {leaf.Attribute("name")}, " +
                    $"{leaf.Attribute("fileBytes")}");
            }
        }

        private static void BuilderExample()
        {
            var builder = new FileSystemBuilder("Development");
            var proj1 = builder.AddDirectory("Project1");
            builder.AddFile("p1f1.txt", 2100);
            builder.AddFile("p1f2.txt", 3100);
            builder.AddDirectory("Sub-dir1");
            builder.AddFile("p1f3.txt", 4100);
            builder.AddFile("p1f4.txt", 5100);
            builder.SetCurrentDirectory("Development");
            var proj2 = builder.AddDirectory("Project2");
            builder.AddFile("p2f1.txt", 6100);
            builder.AddFile("p2f2.txt", 7100);

            Console.WriteLine($"Total size (proj2): {proj2.GetSizeInKB()}");
            Console.WriteLine($"Total size (proj1): {proj1.GetSizeInKB()}");
            Console.WriteLine($"Total size (root): {builder.Root.GetSizeInKB()}");
            Console.WriteLine(JsonConvert.SerializeObject(builder.Root, Formatting.Indented));
        }

        private static void FileSystemComposite()
        {
            var root = new DirectoryItem("Development");
            var proj1 = new DirectoryItem("Project1");
            var proj2 = new DirectoryItem("Project2");
            root.Add(proj1);
            root.Add(proj2);

            proj1.Add(new FileItem("p1f1.txt", 2100));
            proj1.Add(new FileItem("p1f2.txt", 3100));
            var subDir1 = new DirectoryItem("Sub-dir1");
            subDir1.Add(new FileItem("p1f3.txt", 4100));
            subDir1.Add(new FileItem("p1f4.txt", 5100));
            proj1.Add(subDir1);

            proj2.Add(new FileItem("p2f1.txt", 6100));
            proj2.Add(new FileItem("p2f2.txt", 7100));

            Console.WriteLine($"Total size (proj2): {proj2.GetSizeInKB()}");
            Console.WriteLine($"Total size (proj1): {proj1.GetSizeInKB()}");
            Console.WriteLine($"Total size (root): {root.GetSizeInKB()}");
        }

        private static void structuralExample()
        {
            var root = new Composite("root");
            root.Add(new Leaf("Leaf A"));
            root.Add(new Leaf("Leaf B"));

            var comp1 = new Composite("Composite C1");
            comp1.Add(new Leaf("Leaf C1-A"));
            comp1.Add(new Leaf("Leat C1-B"));
            var comp2 = new Composite("Composite C2");
            comp2.Add(new Leaf("Leaf C2-A"));
            comp1.Add(comp2);

            root.Add(comp1);
            root.Add(new Leaf("Leaf C"));

            // Add and remove a leaf
            var leaf = new Leaf("Leaf D");
            root.Add(leaf);
            root.Remove(leaf);

            // Recursively display tree
            comp1.PrimaryOperation(1);
        }
    }
}
