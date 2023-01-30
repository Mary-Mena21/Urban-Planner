using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner
{
    internal class Building
    {
        /*---------Private Fields----------*/

        private string _designer = "Mariana"; //field

        private DateTime _dateConstructed;

        private string _address;

        private string _owner;




        /*---------Public Properties----------*/

        public string Designer
        {
            get {return  _designer; }
            set { _designer = value; }
        }

        public string Address
        {
            get { return _address; }
            //set { _address = value; }   //change the value
        }

        public string Owner
        {
            get { return _owner; }
            set { _owner = value; }   //change the value
        }
        public DateTime DateConstructed
        {
            get { return _dateConstructed; }
            //set { _address = value; }   //change the value
        }

        public int Stories
        {
            get;set;
        }

        public double Width

        {
            get; set;
        }

        public double Depth
        {
            get;set;
        }

        public double Volume
        {
            get {return Width*Depth*(3*Stories); }
        }
        /*---------Constructor-Method---------*/

        public Building(string address)
        {
           this._address = address;

        }
        /*---------Methods---------*/

        public void Construct()
        {
            this._dateConstructed = DateTime.Now;

        }

        public void Purchase(string owner)
        {
            this._owner = owner;
        }



        //public double VolumeValue(double Width, double Depth, int Stories)
        //{
        //    return Width * Depth * (Stories * 3);
        //}
    }
}




/*
 
  private string name;
  private int age;
  //constructor
  public User(string name, int age)
  {
    this.name = name;
    this.age = age;
  }
  //getters
  public String GetName() { return name; }
  public int GetAge() { return age; }
}
 

 */