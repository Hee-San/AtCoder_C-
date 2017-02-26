// B - 罠
// http://abc002.contest.atcoder.jp/tasks/abc002_2
using System;
using System.Linq;

namespace ABC002B {
	class Program {
		public Program() {}
		
		public static void Main() {
			new Program().Calc();
		}
		
		void Calc() {
			Output(string.Join("",
								Input.Split('a', 'i', 'u', 'e', 'o')
									.ToArray()
								));
				
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