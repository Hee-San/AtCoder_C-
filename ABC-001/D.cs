// D - 感雨時刻の整理
// http://abc001.contest.atcoder.jp/tasks/abc001_4
using System;
using System.Linq;

namespace ABC001D {
	class Program {
		public Program() {}
		
		public static void Main() {
			new Program().Calc();
		}
		
		void Calc() {
			var N = int.Parse(Input);
			var timeTable = new int[N][];
			
			for(int i = 0; i < N; i++)
				timeTable[i] = aroundTime(InputMin);
			
			var soatedTimeTable = timeTable.OrderBy(i => i[0])
											.ToArray();
			var period = soatedTimeTable[0];
			
			for(int i = 1; i < N; i++) {
				var lastPeriod = period;
				period = soatedTimeTable[i];
				
				if(lastPeriod[1] >= period[0]) {
					period[0] = lastPeriod[0];
					if(period[1] < lastPeriod[1])
						period[1] = lastPeriod[1];
				} else {
					OutputPeriod(lastPeriod);
				}
			}
			OutputPeriod(period);
		}
		
		String Input {
			get {
				return Console.ReadLine();
			}
		}
		
		void Output(String str) {
			Console.WriteLine(str);
		}
		
		int[] InputMin {
			get {
				return Input
						.Split('-')
						.Select(i => int.Parse(i))
						.Select(i => (i / 100) * 60 + i % 100)
						.ToArray();
			}
		}
		
		int[] aroundTime(int[] min) {
			min[1] += 4;
			return min.Select(i => i / 5)
						.Select(i => i * 5)
						.ToArray();
		}
		
		void OutputPeriod(int[] p) {
			Output((p[0] / 60 * 100 + p[0] % 60).ToString("D4") + "-" + (p[1] / 60 * 100 + p[1] % 60).ToString("D4"));
		}
	}
}