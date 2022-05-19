using System;
using System.Collections.Generic;

namespace Ex04.Menus.Delegates
{
    public class MenuItem : Item
    {
        private const string k_Seperator = "-----------------------";

        private enum eExitPoint
        {
            Exit,
            Back
        }

        private readonly List<Item> r_ItemList;

        public MenuItem(string i_Title) : base(i_Title)
        {
            r_ItemList = new List<Item>();
            ItemLevel++;
        }

        public List<Item> ItemList
        {
            get
            {
                return r_ItemList;
            }
        }

        public void AddItem(Item i_ItemToAdd)
        {
            ItemList.Add(i_ItemToAdd);
        }

        private void printMenuItem()
        {
            int numberChoice = 1;
            Console.WriteLine(ItemTitle);
            Console.WriteLine(k_Seperator);
            foreach (Item item in ItemList)
            {
                Console.WriteLine(string.Format("{0} -> {1}", numberChoice, item.ItemTitle));
                numberChoice++;
            }

            Console.WriteLine(string.Format("0 -> {0}", isBackOrExit().ToString()));
            Console.WriteLine(k_Seperator);
        }

        internal override void Execute()
        {
            bool isWantToExit = false;
            bool isValid = false;
            string userInputString;
            int userInput = 0;

            while (!isWantToExit)
            {
                while (!isValid)
                {
                    printMenuItem();
                    Console.WriteLine("Enter your requst: ");
                    userInputString = Console.ReadLine();
                    try
                    {
                        userInput = isValidInput(userInputString);
                        isValid = true;
                    }
                    catch (Exception ex)
                    {
                        Console.Clear();
                        Console.WriteLine(ex.Message);
                        Console.Write(Environment.NewLine);
                    }
                }

                if (userInput != 0)
                {
                    Console.Clear();
                    ItemList[userInput - 1].Execute();
                    Console.Clear();
                    isValid = false;
                }
                else
                {
                    isWantToExit = true;
                }
            }
        }

        private eExitPoint isBackOrExit()
        {
            return ItemLevel == 0 ? eExitPoint.Exit : eExitPoint.Back;
        }

        private int isValidInput(string i_UserInput)
        {
            int userInput;

            if (!int.TryParse(i_UserInput, out userInput))
            {
                throw new Exception(string.Format("'{0}' is invalid input! You can choose only digit!", i_UserInput));
            }

            if (userInput > ItemList.Count || userInput < 0)
            {
                throw new Exception(string.Format("'{0}' is invalid input! Please choose number between 0 - {1}", i_UserInput, ItemList.Count));
            }

            return userInput;
        }
    }
}