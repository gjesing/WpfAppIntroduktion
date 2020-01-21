using System;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Media;

namespace WpfAppIntroduktion.BIZ
{
    public class ClassBIZ
    {
        public ClassBIZ()
        {

        }

        public void Delopgave12(ListBox listBox)
        {
            ClearList(listBox);
            int number = 4711;
            while (number >= 4711 && number <= 4736)
            {
                listBox.Items.Add(number.ToString());
                number++;
            }
        }

        public void Delopgave13(ListBox listBox)
        {
            ClearList(listBox);
            Random random = new Random();
            for (int i = 0; i < 25; i++)
            {
                listBox.Items.Add(random.Next(100000, 1000001));
            }
        }

        public void Delopgave14(ListBox listBox)
        {
            ClearList(listBox);
            Random random = new Random();
            List<int> listOfNumbers = new List<int>();
            for (int i = 0; i < 25; i++)
            {
                listOfNumbers.Add(random.Next(100000, 1000001));
            }
            listOfNumbers.Sort();
            foreach (int number in listOfNumbers)
            {
                listBox.Items.Add(number);
            }
        }

        public void Delopgave15(ListBox listBox)
        {
            ClearList(listBox);
            Random random = new Random();
            List<int> listOfNumbers = new List<int>();
            for (int i = 0; i < 25; i++)
            {
                listOfNumbers.Add(random.Next(100000, 1000001));
            }
            List<int> listOfNumbersSorted = new List<int>(listOfNumbers);
            listOfNumbersSorted.Sort();
            for (int i = 0; i < listOfNumbers.Count; i++)
            {
                listBox.Items.Add(listOfNumbers[i] + "\t" + listOfNumbersSorted[i]);
            }
        }

        public void Delopgave16(ListBox listBox)
        {
            ClearList(listBox);
            Random random = new Random();
            List<int> listOfNumbers = new List<int>();
            for (int i = 0; i < 25; i++)
            {
                int number = random.Next(100000, 1000001);
                listOfNumbers.Add(number);
                listBox.Items.Add(number);
            }
            listBox.Items.Add("");
            listBox.Items.Add("Gennemsnitsværdi: " + GetAverage(listOfNumbers));
        }

        public void Delopgave17(ListBox listBox)
        {
            ClearList(listBox);
            Random random = new Random();
            List<int> listOfNumbers = new List<int>();
            for (int i = 0; i < 25; i++)
            {
                listOfNumbers.Add(random.Next(100000, 1000001));
            }
            int average = GetAverage(listOfNumbers);
            listOfNumbers.Sort();
            foreach (int number in listOfNumbers)
            {
                listBox.Items.Add($"{number} - {average} = {number - average}");
            }
        }

        public List<string> Delopgave18()
        {
            Random random = new Random();
            List<int> listOfNumbers = new List<int>();
            List<string> stringListOfNumbers = new List<string>();
            for (int i = 0; i < 25; i++)
            {
                listOfNumbers.Add(random.Next(100000, 1000001));
            }
            int average = GetAverage(listOfNumbers);
            listOfNumbers.Sort();
            foreach (int number in listOfNumbers)
            {
                stringListOfNumbers.Add($"{number} + {average} = {number + average}");
            }
            return stringListOfNumbers;
        }

        public void Delopgave19(ListBox listBox)
        {
            ClearList(listBox);
            Random random = new Random();
            List<int> listOfNumbers = new List<int>();
            for (int i = 0; i < 25; i++)
            {
                listOfNumbers.Add(random.Next(100000, 1000001));
            }
            int average = GetAverage(listOfNumbers);
            listOfNumbers.Sort();
            foreach (int number in listOfNumbers)
            {
                ListBoxItem listBoxItem = new ListBoxItem();
                if (number % 2 == 0)
                {
                    listBoxItem.Background = Brushes.HotPink;
                }
                else
                {
                    listBoxItem.Background = Brushes.AliceBlue;
                }
                listBoxItem.Content = $"{number} - {average} = {number - average}";
                listBox.Items.Add(listBoxItem);
            }
        }

        public void Delopgave110(ListBox listBox)
        {
            ClearList(listBox);
            Random random = new Random();
            List<int> listOfNumbers = new List<int>();
            List<ListBoxItem> listOfListBoxItems = new List<ListBoxItem>();
            for (int i = 0; i < 25; i++)
            {
                int number = random.Next(100000, 1000001);
                listOfNumbers.Add(number);
            }
            listOfNumbers.Sort();
            int average = GetAverage(listOfNumbers);
            foreach (int number in listOfNumbers)
            {
                ListBoxItem listBoxItem = new ListBoxItem();
                if (number % 2 == 0)
                {
                    listBoxItem.Background = Brushes.HotPink;
                }
                else
                {
                    listBoxItem.Background = Brushes.AliceBlue;
                }
                listBoxItem.Content = $"{number} - {average} = {number - average}";
                listOfListBoxItems.Add(listBoxItem);
            }
            listBox.ItemsSource = listOfListBoxItems;
        }

        private int GetAverage(List<int> listOfNumbers)
        {
            int average = 0;
            foreach (int number in listOfNumbers)
            {
                average += number;
            }
            return average / listOfNumbers.Count;
        }

        private void ClearList(ListBox listBox)
        {
            if (listBox.ItemsSource != null)
            {
                listBox.ItemsSource = null;
            }
            listBox.Items.Clear();
        }
    }
}
