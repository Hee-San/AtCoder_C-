//A - êœê·ê[ç∑
//http://abc001.contest.atcoder.jp/tasks/abc001_1
using System;

namespace ABC001A {
	class Program {
		public Program() {}
		
		public static void Main() {
			new Program().Calc();
		}
		
		void Calc() {
			var h1 = InputInt;
			var h2 = InputInt;
			Console.WriteLine(h1 - h2);
		}
		
		int InputInt {
			get {
				return int.Parse(Console.ReadLine());
			}
		}
	}
}