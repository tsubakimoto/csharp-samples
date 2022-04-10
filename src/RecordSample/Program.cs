// https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-9#record-types
// https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/record
Person person1 = new("Yuta", "Matsumura");
Console.WriteLine(person1.Greet());
Console.WriteLine();

// Cannot edit a property.
// person.FirstName = "Yuta2";
// Console.WriteLine(person.Greet());

Person person2 = new("Yuta", "Matsumura");
Console.WriteLine(person2.Greet());
Console.WriteLine($"{nameof(person1)} == {nameof(person2)} : {person1 == person2}");
Console.WriteLine();

Person person3 = person1 with { LastName = "Tsubakimoto" };
Console.WriteLine(person3.Greet());
Console.WriteLine($"{nameof(person1)} == {nameof(person3)} : {person1 == person3}");
Console.WriteLine();

List<Person> people = new List<Person> { person1, person2, person3 };
Console.WriteLine($"How many people : {people.Count}");
Console.WriteLine($"People names : {string.Join(",", people.Select(p => p.LastName))}");
Console.WriteLine();
