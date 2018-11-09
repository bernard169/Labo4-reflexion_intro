using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo_4
{
    public class Item
    {
        private static int nextid = 0;

        public readonly int ID;
        private readonly string name;
        private readonly int price;

        public Item(string name, int price)
        {
            this.ID = ++nextid;
            this.name = name;
            this.price = price;
        }

        public string Name
        {
            get { return name; }
        }

        public int Price
        {
            get { return price; }
        }
    }
    public class Introspection
    {
        public readonly List<FieldInfo> attributs;
        public readonly List<MethodInfo> methods;
        private readonly Type type;
        public Introspection(Type type)
        {
            this.type = type;
            attributs = new List<FieldInfo>();
            methods = new List<MethodInfo>();
            foreach (FieldInfo info in type.GetFields (BindingFlags.NonPublic | BindingFlags.Static))
            {
                attributs.Add(info);
            }
            foreach (MethodInfo info in type.GetMethods (BindingFlags.NonPublic | BindingFlags.Static))
            {
                methods.Add(info);
            }
        }
        public override string ToString()
        {
            return String.Format(("Type : {0}" +
                "\n Attributs : {1}" +
                "\n Methods : {2}"), type, attributs, methods);
        }
    }
}
