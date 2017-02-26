// A - 正直者
// http://abc002.contest.atcoder.jp/tasks/abc002_1
using System;
using System.Linq;

namespace ABC002A {
	class Program {
		public Program() {}
		
		public static void Main() {
			new Program().Calc();
		}
		
		void Calc() {
			Output(Input
					.Split(' ')
					.Select(i => int.Parse(i))
					.Max()
					.ToString());
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