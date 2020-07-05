

namespace UserIO {
	class ConsoleIO : GameIO {
		public string readLine(string prefix) {
			System.Console.Write(prefix);
			return System.Console.ReadLine();
		}
		
		public void printLine(string line) {
			System.Console.WriteLine(line);
			
		}
	}
}
