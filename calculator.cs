class Calculator{
	static void main(string[] args)
	{
		int a = 10;
		int b = 6;
		
		Console.WriterLine("Hasil Penambahan: {0} + {1} = {2}", a, b, Penambahan(a, b));
		Console.WriterLine("Hasil Pengurangan: {0} - {1} = {2}", a, b, Pengurangan(a, b));
		
		Console.WriterLine("\nTekan sembarang key untuk Keluar");
		console.RedKey();
	}
	static int Penambahan(int a, int b)
	{
		return a + b;
	}
	static int Pengurangan(int a, int b)
	{
		return a - b;
	}
}