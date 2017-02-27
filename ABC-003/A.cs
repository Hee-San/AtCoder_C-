// A - AtCoderŽÐ‚Ì‹‹—¿
// http://abc003.contest.atcoder.jp/tasks/abc003_1
using System;
using System.Linq;

namespace ABC003A {
	class Program {
		public Program() {}
		
		public static void Main() {
			new Program().Calc();
		}
		
		void Calc() {
			var N = int.Parse(Input);
			var ans = 5000 * (N + 1);
			Output(ans.ToString());
		}
		
		String Input {
			get {
				return Console.ReadLine();
			}
		}
		
		void Output(String str) {
			Console.WriteLine(str);
		}
	}
}