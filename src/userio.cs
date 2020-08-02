

namespace UserIO {
	
	public interface GameIO {
		public string? readLine(string prefix = "> ");
		public void printLine(string text);
	}
}
