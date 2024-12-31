using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G05_OOP01
{
    internal class Car
    {
		#region Attributes

		private int id;
		private int speed;
		private string model;

		#endregion

		#region Properties
		public string Model
		{
			get { return model; }
			set { model = value; }
		}


		public int Speed
		{
			get { return speed; }
			set { speed = value; }
		}


		public int Id
		{
			get { return id; }
			set { id = value; }
		}

        #endregion

        public Car(int id , int speed , string model) : this(id,speed)
        {
			
			this.model = new string(model);
            
        }
        public Car(int id, int speed)  : this(id)
        {
            this.speed = speed;

        }

        public Car(int id) 
        {
            this.id = id;


        }

        public override string ToString()
        {
            return $"Id {Id}, Speed: , Model: {Model}";
        }
    }
}
