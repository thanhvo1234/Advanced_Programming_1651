using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASM2_AdvancedProgramming_1651;

namespace ASM2_AdvancedProgramming_1651
{
    internal class ShowRoom : IInfor
    {
        public List<Car> CarList = new List<Car>();

        public ShowRoom()
        {

        }

        public bool CheckId(int id)
        {
            Car carInList = CarList.FirstOrDefault(i => i.Id.Equals(id));
            if (carInList != null) return true;
            return false;
        }

        public void AddCar(Car car)
        {
            try
            {
                if (CheckId(car.Id))
                {
                    throw new ArgumentException("!!! ID is duplicated. Please enter another ID !!!");
                }
                else
                {
                    CarList.Add(car);
                }
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }

        public bool RemoveCarByModel(string _model)
        {
            Car carInList = CarList.FirstOrDefault(i => i.Model.Equals(_model));
            if (carInList != null)
            {
                CarList.Remove(carInList);
                Console.WriteLine("(^.^) Remove successfully!");
                return true;
            }
            return false;
        }

        public string PrintInfor()
        {
            string result = "";
            foreach (var b in CarList)
            {
                result = result + b.PrintInfor();
            }
            return result;
        }

        public string FindCarsByModel(string _model)
        {
            Car carInList = CarList.FirstOrDefault(i => i.Model.Contains(_model));
            if (carInList != null) return carInList.PrintInfor();
            return "!!! There is no car with that model !!!";
        }

        public string FindCarsByBrand(string brand)
        {
            string result = "";
            foreach (var car in CarList.FindAll(car => car.Brand.Contains(brand)))
            {
                result += car.PrintInfor();
            }
            return result;
        }
    }
}
