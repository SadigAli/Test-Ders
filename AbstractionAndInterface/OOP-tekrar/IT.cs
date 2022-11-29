using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_tekrar
{
    public class IT
    {
        /// <summary>
        /// Fields
        /// </summary>
        private int _id;
        private string _name;
        /// <summary>
        /// Property
        /// </summary>
        public string Name {
            get
            {
                return _name; 
            }
            set
            {
                _name = value;
            }
        }

        public IT(string name)
        {
            Name = name;
        }



        /// <summary>
        /// Methods
        /// </summary>
        /// <returns></returns>
        public string GetName()
        {
            return _name;
        }

        public void setName(string name)
        {
            this._name = name;
        }

        /// <summary>
        /// Virtual- override Polymorphism
        /// </summary>
        /// <returns></returns>
        public virtual string FullInfo()
        {
            return Name;
        }

    }
}
