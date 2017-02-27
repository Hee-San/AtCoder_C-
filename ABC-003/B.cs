// B - AtCoderトランプ
// http://abc003.contest.atcoder.jp/tasks/abc003_2
using System;
using System.Linq;

namespace ABC003B {
	class Program {
		public Program() {}
		
		public static void Main() {
			new Program().Calc();
		}
		
		void Calc() {
			Char[]  AtCoder = {'a', 't', 'c', 'o', 'd', 'e', 'r'};
			var S = Input.ToCharArray();
			var T = Input.ToCharArray();
			for(int i = 0; i < S.Length; i++) {
				if(S[i] == T[i]) continue;
 				if(S[i] == '@' && AtCoder.Contains(T[i])) continue;
 				if(T[i] == '@' && AtCoder.Contains(S[i])) continue;
 				Output("You will lose");
 				return;
			}
			Output("You can win");
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