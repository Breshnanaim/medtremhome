using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace medtremhome
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Apparment> room = new List<Apparment>();
        // Apparment currentroom = null;
        //Apparment roomselect = null;
        Apparment roomselect = null;


        public MainWindow()
        {
            InitializeComponent();
            Preload();
            DisplayToListBox();


        }

        public void DisplayToListBox()
        {
            // Clear list box first
            llisttext.Items.Clear();

            for (int i = 0; i < room.Count; i++)
            {
                llisttext.Items.Add(room[i]);
            }

        }

        public void Preload()
        {
            Random rand = new Random();
            for (int i = 100; i < 301; i++)
            {
                string apart = "H" + i;
                if (rand.Next(2) != 0)
                {
                    int monthly = rand.Next(1000, 3000);
                    int numberOfbedrooms = rand.Next(1, 4);

                    //room.Add(new Apparment(apart, "mustafa", "Asma", monthly, numberOfbedrooms));

                    Apparment newlearner = new Apparment(apart, "breshna", "noon", monthly, numberOfbedrooms);
                    room.Add(newlearner);
                    //llisttext.Items.Add(room);
                }

            }
        }


        /* private void addtennatbotton_Click(object sender, RoutedEventArgs e)
          {

          }
        */

        private void llisttext_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = llisttext.SelectedIndex;
            //Apparment roomselect = room[index];

            if (index >= 0)
            {
                roomselect = room[index];

                // lblFirstName.Content = selectedStudent.FirstName;
                // lblLastName.Content = selectedStudent.LastName;
                apptext.Text = roomselect.ToString();
                firsttext.Text = roomselect.ToString(); 
                lasttext.Text = roomselect.ToString();
                paymenttext.Text = roomselect.ToString();
                apptext.Text = roomselect.ToString();
            }
        }
            private void addbotton_Click(object sender, RoutedEventArgs e)
            {
                int appnum = int.Parse(apptext.Text);
                string firstname = firsttext.Text;
                String lastname = lasttext.Text;
                decimal monthlydue = decimal.Parse(paymenttext.Text);
            int roomnum=int.Parse(roomtext.Text);   

                roomselect.numberOfBedrooms = appnum;
            roomselect.FirstName= firstname;
            roomselect.LastName= lastname;
                roomselect.MonthlyPayment = monthlydue;
            roomselect.NumberOfBedrooms = roomnum;

                DisplayToListBox();
            }

        private void removebotton_Click(object sender, RoutedEventArgs e)
        {
            //int remove = int.Parse(llisttext.Items);
            //room.RemoveAt(remove);
            //llisttext.Items.RemoveAt();
             int selectedIndex = llisttext.SelectedIndex;
            room.Remove(roomselect);

            

        }

        private void monthlyduebotton_Click(object sender, RoutedEventArgs e)
        {
            int selectedIndex = llisttext.SelectedIndex;
            for (int i = 0; i < room.Count; i++)
            {
                if (monthlyduebotton==monthy)
                {
                    room.Remove(roomselect);

                    
                }
                else {

                    MessageBox.Show("make fullpayment ");
                }

            }
        }

        private void paymentinfullbotton_Click(object sender, RoutedEventArgs e)
        {
            if
        }
    }

        /*
              // void addtennatbotton_Click(object sender, RoutedEventArgs e)
            //  {
                 // string appnum = apptext.Text;
                 // string firstname = firsttext.Text;
                 // string lastname = lasttext.Te
                  //string homroom = roomtext.Text;
                //  string renttext = paymenttext.Text;
                 // int homeroomme=int.Parse(homroom);
                //  int paymenttexts = int.Parse(renttext);
                 // room.Add(new Apparment(appnum, firstname, lastname, paymenttexts, homeroomme));
                 // llisttext.Items.Add(room);
                //  Preload();
        */
    }



