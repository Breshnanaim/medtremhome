using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Xml.Resolvers;

namespace medtremhome
{
   public class Apparment
    {
       public String ApartmentNumber;
        public String firstName;
        public String lastName;
         Decimal monthlyPayment;
         Decimal currentBalance;
        public int numberOfBedrooms;
        String apartmentNotes;
        public bool isOccupied;

        public Apparment(string apartmentNumber, string firstName, string lastName, decimal monthlyPayment,int numberOFBedrooms)
        {
            ApartmentNumber = apartmentNumber;
            firstName = firstName;
            lastName = lastName;
            monthlyPayment = monthlyPayment;
           numberOfBedrooms = numberOFBedrooms;
        }
        public Apparment(bool isOccupied) {

            IsOccupied= isOccupied;

            
        }
        public override string ToString()
        {
            return $"{ApartmentNumber} {firstName}breshna {lastName} naim{monthlyPayment}{numberOfBedrooms}";
        }


        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public decimal MonthlyPayment { get => monthlyPayment; set => monthlyPayment = value; }
        public decimal CurrentBalance { get => currentBalance; set => currentBalance = value; }
        public int NumberOfBedrooms { get => numberOfBedrooms; set => numberOfBedrooms = value; }
        public string ApartmentNotes { get => apartmentNotes; set => apartmentNotes = value; }
        public bool IsOccupied { get => isOccupied; set => isOccupied = false; }

       
    }
    
    

    
        
    }
