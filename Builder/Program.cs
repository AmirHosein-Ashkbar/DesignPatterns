using Builder;

var builder = new HouseBuilder();

builder.SetStories(4).SetDoorType(Material.Metal).SetFloorType(Material.Stone);

var house = builder.Build();

Console.WriteLine(house);



var director = new Director(builder);

var oneStoryWoodenHouse = director.BuildOneStoryWoodenHouse();


Console.WriteLine(oneStoryWoodenHouse);

