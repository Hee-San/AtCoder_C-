// C - AtCoderプログラミング講座
// http://abc003.contest.atcoder.jp/tasks/abc003_3
using System;
using System.Linq;

namespace ABC003C {
	class Program {
		public Program() {}
		
		public static void Main() {
			new Program().Calc();
		}
		
		void Calc() {
			var NK = Input
					.Split(' ')
					.Select(i => int.Parse(i))
					.ToArray();
			var R = Input
					.Split(' ')
					.Select(i => int.Parse(i))
					.OrderBy(i =>i)
					.ToArray();
			
			double rate = 0;
			for(int i = NK[0] - NK[1]; i < NK[0]; i++) {
				rate = (rate + R[i]) / 2;
			}
			Output(rate.ToString());
			return;
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