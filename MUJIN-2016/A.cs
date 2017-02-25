// MUJIN Progtaming Charange - MUJIN
// http://mujin-pc-2016.contest.atcoder.jp/tasks/mujin_pc_2016_a
using System;
using System.Linq;

namespace MUJIN_2016_A {
	class Program {
		public Program() {}
		
		public static void Main() {
			new Program().Calc();
		}
		
		void Calc() {
			var N = Input;	// Number of elements
			if(N == "O" || N == "P" || N == "K" || N == "L")
				Output("Right");
			else Output("Left");
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