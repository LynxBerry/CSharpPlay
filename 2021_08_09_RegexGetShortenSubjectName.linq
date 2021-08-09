<Query Kind="Program" />

void Main()
{
	var certSubjectName = "CN=Steven Shao, OU=UserAccounts, DC=fareast, DC=corp, DC=microsoft, DC=com";
	certSubjectName = Regex.Replace(certSubjectName, @"CN=([^,]+).*", "$1");
	
	certSubjectName.Dump();
	
}

// Define other methods and classes here
