using System;
 
class Program{
	static void Main(){

		string[] s = Console.ReadLine().Split(' ');
		double[] p = Array.ConvertAll(s, Double.Parse) ;
		for(int i = 0; i < 13; i++) Console.WriteLine((p[i] + 0.05) * 60);
	}
}