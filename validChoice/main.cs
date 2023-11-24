using System;
using System.Collections.Generic;

class Program {

  static string createMenu (List<string> choices, string menuTitle){
    int num = 1;
    string menu = menuTitle + "\n";

    for (int i = 1; i < choices.Count; i++){
      menu += num + ". " + choices[i] + "\n";
      num++;
    }

    return menu;
  }

  
  public static void Main (string[] args) {    

    List<string> cList = new List<string>();
    cList.Add("Add");
    cList.Add("Subtract");
    cList.Add("Multiply");
    cList.Add("Divide");
    cList.Add("Quit");
    string menu = createMenu(cList, "Main Menu");
    Console.WriteLine(menu);

    Console.WriteLine("Number choice: ");
    string choice1 = Console.ReadLine();
    int number1;
    bool canConvert = int.TryParse(choice1, out number1);

    while (canConvert == false || Int32.Parse(choice1) < 1 || Int32.Parse(choice1) > cList.Count){
      Console.WriteLine("Invalid choice. Try again.");
      Console.WriteLine("Number choice: ");
      choice1 = Console.ReadLine();
      canConvert = int.TryParse(choice1, out number1);
    }


    
    Console.WriteLine ("You chose " + Int32.Parse(choice1));
  }
}