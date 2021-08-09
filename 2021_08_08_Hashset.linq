<Query Kind="Program" />

void Main()
{
	var set = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
	set.Add("abc");
	set.Add("efg");
	set.Dump();
	
	set.Contains("Efg").Dump();
	
	
}

// Define other methods and classes here