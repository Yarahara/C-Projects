using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.Versioning;

class Program {

  static string createMenu (List<string> choices, string menuTitle){
    int num = 1;
    string menu = menuTitle + "\n";

    for (int i = 0; i < choices.Count; i++){
      menu += num + ". " + choices[i] + "\n";
      num++;
    }

    return menu;
  }

  public static int validChoice(int choices, string menuStr){
    Console.WriteLine("Enter choice: ");
    string choice = Console.ReadLine();
    bool canConvert = int.TryParse(choice, out int number);
    while (canConvert == false || Int32.Parse(choice) < 1 || Int32.Parse(choice) > choices){
        Console.WriteLine("Error invalid choice please try again: ");
        Console.WriteLine(menuStr);
        Console.WriteLine("Enter choice: ");
        choice = Console.ReadLine();
        canConvert = int.TryParse(choice, out number);
    }
    return Int32.Parse(choice);
  }

  public static float deposit(float checkBal){
    Console.WriteLine("How much would you like to deposit? ");
    string uDeposit = Console.ReadLine();
    float atmDeposit = float.Parse(uDeposit);
    checkBal += atmDeposit;
    return checkBal;
  }

  public static float withdrawal(float checkBal){
    Console.WriteLine("How much would you like to withdraw? ");
    string uW = Console.ReadLine();
    float uWithdrawal = float.Parse(uW);
    if (uWithdrawal > checkBal){
        Console.WriteLine("Withdrawal not possible. Overdrafts not allowed");
    }
    else
    {
        checkBal -= uWithdrawal;
    }

    return checkBal;
  }

  public static float handleCheckMenu(float checkBal, string cMenuStr, int numOptions){
    Console.WriteLine(cMenuStr);
    int ckChoice = validChoice(numOptions, cMenuStr);
    while (ckChoice != numOptions)
    {
        if (ckChoice == 1)
        {
            checkBal = deposit(checkBal);
        }
        else if (ckChoice == 2)
        {
            checkBal = withdrawal(checkBal);
        }
        else if (ckChoice == 3)
        {
            Console.WriteLine($"Your checking balance is ${checkBal}");
        }
        Console.WriteLine(cMenuStr);
        ckChoice = validChoice(numOptions, cMenuStr);
    }
    return checkBal;
  }

  public static float calcInterest(float savBal)
  {
    float interestEarned = savBal * 0.02f;
    savBal += interestEarned;
    Console.WriteLine($"You've earned {interestEarned}");
    return savBal;
  }

  public static void displaySaveBalance(float savBal)
  {
    Console.WriteLine($"Your savings balance is {savBal}");
  }

  public static float handleSavingsMenu(float savBal, string sMenuStr, int numOptions)
  {
    Console.WriteLine(sMenuStr);
    int savChoice = validChoice(numOptions, sMenuStr);
    while (savChoice != numOptions)
    {
        if (savChoice == 1)
        {
            savBal = calcInterest(savBal);
        }
        else if (savChoice == 2)
        {
            displaySaveBalance(savBal);            
        }
        Console.WriteLine(sMenuStr);
        savChoice = validChoice(numOptions, sMenuStr);  
    }
    return savBal;
  }


  
  
  public static void Main (string[] args) {    

    List<string> mList = new List<string>
    {
        "Savings", "Checking", "Quit"
    };
    List<string> sList = new List<string>
    {
        "Display Interest Earned", "Display Savings Balance",
        "Back to Main"
    };
    List<string> cList = new List<string>
    {
        "Deposit", "Withdrawal", "Display Checking Balance"
        , "Back to Main"
    };
    string mMenu = createMenu(mList, "Main Menu");
    string sMenu = createMenu(sList, "Main Menu");
    string cMenu = createMenu(cList, "Main Menu");
    Console.WriteLine(mMenu);

    float savBal = 100;
    float checkBal = 10;

    int mainChoice = validChoice(mList.Count, mMenu);
    while (mainChoice != mList.Count)
    {
        if (mainChoice == 1)
        {
            savBal = handleSavingsMenu(savBal, sMenu, sList.Count);
        }
        else if (mainChoice == 2)
        {
            checkBal = handleCheckMenu(checkBal, cMenu, cList.Count);
        }
        Console.WriteLine(mMenu);
        mainChoice = validChoice(mList.Count, mMenu);
    }
    Console.WriteLine("Exiting bank");



    
  }
}