// B - 視程の通報
// http://abc001.contest.atcoder.jp/tasks/abc001_2
using System;

namespace ABC001B {
	class Program {
		public Program() {}
		
		public static void Main() {
			new Program().Calc();
		}
		
		void Calc() {
			var m = InputInt;	// m[m]
			Console.WriteLine(getVV(m).ToString("D2"));
		}
		
		int InputInt {
			get {
				return int.Parse(Console.ReadLine());
			}
		}
		
		int getVV(int m){
			// SYNOP
			if(m < 100)
				return 0;
			if(100 <= m && m <= 5000)
				return m / 100;
			if(6000 <= m && m <= 30000)
				return (m / 1000) + 50;
			if(35000 <= m && m <= 70000)
				return ((m / 1000) - 30) / 5 + 80;
			if(70000 < m)
				return 89;
			return -1;
		}
	}
}