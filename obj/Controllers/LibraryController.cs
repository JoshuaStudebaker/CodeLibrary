using System;
// using Library.Services

namespace Library.Controllers
{
  private LibraryService _Service { get; set; } = new LibraryService();
  public bool _Running { get; set; } = true;
  public void Run()
  {
    while (_Running)
    {
      GetUserInput();
      Console.WriteLine("Options:\n (A)dd, (R)ead, (C)heckout, Re(t)urn, (D)elete, (Q)uit");
      string userInput = Console.ReadLine().ToLower();
      Console.Clear();
      switch (userInput)
      {
        case "add":
        case "a":
          Add();
          break;

        case "read":
        case "r":
          Read();
          break;

        case "checkout":
        case "c":
          Checkout();
          break;

        case "return":
        case "e":
          Return();
          break;

        case "delete":
        case "d":
          Delete();
          break;

        case "quit":
        case "q":
          Quit();
          break;
      }

    }
  }

  private void GetUserInput()
  {

  }

  private void Add()
  {

  }

  private void Read()
  {

  }

  private void Checkout()
  {

  }

  private void Return()
  {

  }

  private void Delete()
  {

  }

  private void Quit()
  {

  }


}