using System.Diagnostics;

namespace ets2_trainer;

internal class Program {

	internal static string MODULE_NAME = "eurotrucks2";

	public static void Main() {
		var program = Process.GetProcessesByName(MODULE_NAME);

		if (program.Length == 0) {
			Console.WriteLine("You can not run this trainer before launching the game!");
			return;
		}

		var cheats = new Cheats();

		Console.WriteLine("Welcome to ETS 2 Trainer by Despical!");
		Console.WriteLine("Compatible with ETS2 v1.50.1.0s (64 bit)\n");
		Console.WriteLine("What would you like to do?");
		Console.WriteLine("1. Modify Money\n2. Modify Exp\n3. Exit\n");

		for (;;) {
			Console.Write("\nEnter your choice: ");

			var choice = Console.ReadLine();

			switch (choice) {
				case "1":
					Console.Write("Enter the new money: ");

					var moneyInput = Console.ReadLine();
					int money;

					if (int.TryParse(moneyInput, out money)) {
						cheats.SetMoney(money);
						Console.WriteLine("Updated money amount.");
					} else {
						Console.WriteLine("Invalid input. Please enter a valid integer.");
					}

					break;
				case "2":
					Console.Write("Enter the exp amount: ");

					var expInput = Console.ReadLine();
					int exp;

					if (int.TryParse(expInput, out exp)) {
						cheats.SetExp(exp);
						Console.WriteLine("Updated exp amount.");
					} else {
						Console.WriteLine("Invalid input. Please enter a valid integer.");
					}

					break;
				case "3":
					Console.WriteLine("Exiting program...");
					return;
				default:
					Console.WriteLine("Invalid choice. Please enter a valid option.");
					break;
			}
		}
	}
}