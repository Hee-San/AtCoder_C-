// MUJIN Progtaming Charange - Robot Arm
// http://mujin-pc-2016.contest.atcoder.jp/tasks/mujin_pc_2016_b
using System;
using System.Linq;

namespace MUJIN_2016_B {
	class Program {
		public Program() {}
		
		public static void Main() {
			new Program().Calc();
		}
		
		void Calc() {
			var L = Input				// Array : l
					.Split(' ')
					.Select(i => int.Parse(i))
					.ToArray();
			
			int maxL = L.Sum();
			int minL = 2 * L.Max() - maxL;
			if(minL < 0) minL = 0;
			
			double area = (maxL * maxL - minL * minL) * Math.PI;
			
			Output(area.ToString());
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