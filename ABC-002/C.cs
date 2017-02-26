// C - 直訴
// http://abc002.contest.atcoder.jp/tasks/abc002_3
using System;
using System.Linq;

namespace ABC002C {
	class Program {
		public Program() {}
		
		public static void Main() {
			new Program().Calc();
		}
		
		void Calc() {
			var p = Input.Split(' ')
								.Select(i => int.Parse(i))
								.ToArray();
			double area = Math.Abs(p[0] * (p[3] - p[5])
								+ p[2] * (p[5] - p[1])
								+ p[4] * (p[1] - p[3]));
			Output((area / 2).ToString("F3"));
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