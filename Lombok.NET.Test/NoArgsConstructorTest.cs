using Xunit;

namespace Lombok.NET.Test;

public class NoArgsConstructorTest
{
	public NoArgsConstructorTest()
	{
		var p = new NoArgsPerson();
		
		Assert.NotNull(p);
	}
}
	
[NoArgsConstructor]
partial class NoArgsPerson
{
	private readonly string _name;
	private int _age;
		
	public NoArgsPerson(string name, int age)
	{
		_name = name;
		_age = age;
	}
}