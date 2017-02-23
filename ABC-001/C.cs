// C - •——ÍŠÏ‘ª
// http://abc001.contest.atcoder.jp/tasks/abc001_2
using System;
using System.Linq;

namespace ABC001A {
	class Program {
		public Program() {}
		
		public static void Main() {
			new Program().Calc();
		}
		
		void Calc() {
			var values = InputInt;
			var dir = Direction(values[0]);
			var w = WindPow(values[1]);
			if(w == 0) dir = "C";
			Console.WriteLine(dir + " " + w);
		}
		
		int[] InputInt {
			get {
				return Console.ReadLine()
					.Split(' ')
					.Select(i => int.Parse(i))
					.ToArray();
			}
		}
		
		String Direction(int deg) {
			// deg [“x*10]
			String[] dir = {"N", "NNE", "NE", "ENE",
							"E", "ESE", "SE", "SSE",
							"S", "SSW", "SW", "WSW",
							"W", "WNW", "NW", "NNW"};
			int i = ((deg * 10 + 1125) / 2250) % 16;
			return dir[i];
		}
		
		int WindPow(int dis) {
			// dis [m]
			int[] range = {15, 93, 201, 327, 477, 645, 831, 1029, 1245, 1467, 1707, 1959};
			for(int i = 0; i < 12; i++){
				if(dis < range[i]) return i;
			}
			return 12;
		}
	}
}