# CSharp-Try
A better way to Try/Catch in C#

# Examples

### Use as an Easy Convert.To Proxy:
```csharp
string input = "false"
bool? output = null;
Try.Run(Convert.ToBoolean, input, out output);

if (output.HasValue) {
  // Do stuff with "output.Value"
}
```

### Use as a Cleaner Try, Multiple Catch Statement:
```csharp
var request = System.Net.HttpWebRequest.Create("https://www.google.com");

System.Net.WebResponse response;
Exception exception = Try.Run(request.GetResponse, out response);

if (exception is NotSupportedException)
    Console.WriteLine("We got a 'NotSupportedException' exception :(");

else if (exception is Exception)
    Console.WriteLine("We got an exception, but don't care what it is...");

else
{
    // Use 'response' to get our http information
}
```
