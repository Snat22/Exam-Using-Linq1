using _001Task;
using _001Task.Data;

await using var dataContext = new DataContext();


Console.WriteLine(" Good look 😊😊😊 ");

//1
//Напишите запрос LINQ, чтобы получить всех людей, живущих в городе с населением более 3 милион человек.
//Write a LINQ query to retrieve all the people who live in a city with a population greater than 3 

// var query = (from p in dataContext.Peoples 
//             join c in dataContext.Cities on p.CityId equals c.Id
//             where c.Population > 3000000
//             select new
//             {
//                 people = p
//             }
//             );
//             foreach (var item in query)
//             {
//                     System.Console.WriteLine($"{item.people.FirstName}");
//             }

//2
//Получите все города со средней численностью населения в соответствующей стране
//Retrieve all cities with their respective country's average population

// var query = ( from ct in dataContext.Cities
//     group ct by ct.CountryId into Group
//     select new {
//          Country = Group.Key,
//           AvgPopulation = Group.Average(c => c.Population) });

// foreach (var item in query)
// {
//     System.Console.WriteLine($"Country Id: {item.Country} Population: {item.AvgPopulation} ");
// }

//3
//Получите города с самым высоким населением в каждой стране
//Retrieve the cities with the highest population in each country
// var query = (from ct in dataContext.Cities
//             group ct by ct.CountryId into Group
//             select new
//             {
//                 Country = Group.Key,
//                 Population = Group.OrderByDescending(c=>c.Population).FirstOrDefault()
//             }
//             ).ToList();


// foreach (var item in query)
// {
//     var country = dataContext.Countries.FirstOrDefault(c => c.Id == item.Country);
//     var city = item.Population;
//     Console.WriteLine($"Country: {country.Name}, Largest City: {city.Name}, Population: {city.Population}");
// }

//4
//Получите среднее население городов в каждой стране
//Retrieve the average population of cities in each country

// var query = (from c in dataContext.Cities
//         let avg = dataContext.Cities.Average(e=> c.Population)
//             group c by c.CountryId into Group
//             select new
//             {
//                 Country = Group.Key,
//                 Population = Group.OrderByDescending(c=>c.Population).FirstOrDefault()
//             }
// ).ToList();

// foreach (var item in query)
// {
//     System.Console.WriteLine($"{item.Country} {item.Population.Name} {item.Population.Population}");
// }
//5
//Получить все города, в которых есть человек по имени "Марк".
//Retrieve all cities that have a person with by name "Mark"

    // var query = 
    // from ct in dataContext.Cities
    // where ct.Peoples.Any(p => p.FirstName == "Mark")
    // select ct;

    // foreach (var item in query)
    // {
    //     System.Console.WriteLine($" {item.Id} City Name:{item.Name} ");
    // }


//6
//Получить всех людей вместе с соответствующими названиями городов и стран
//Retrieve all people along with their associated city and country names
// var query = (from p in dataContext.Peoples
//             join ct in dataContext.Cities on p.CityId equals ct.Id
//             join c in dataContext.Countries on ct.CountryId equals c.Id
//             select new 
//             {
//                 Person = p,
//                 City = ct,
//                 Country = c
//             }
// );
// foreach (var item in query)
// {
//     System.Console.WriteLine($" People Name: {item.Person.FirstName} Last Name: {item.Person.LastName} City: {item.City.Name} Country: {item.Country.Name} ");
// }




//7
//Получите все города вместе с соответствующими названиями стран, используя свойство навигации
//Retrieve all cities along with their associated country names using a navigation property
// var query = (from ct in dataContext.Cities 
//             join c in dataContext.Countries on ct.CountryId equals c.Id
//             select new 
//             {
//               City = ct,
//               Country = c  
//             });

//             foreach (var item in query)
//             {
//                 System.Console.WriteLine($"{item.City.Name} {item.Country.Name}");
//             }



//8
//Получить всех людей вместе с связанными с ними городом и страной.
//Retrieve all people along with their associated city and country 

// var query = (from p in dataContext.Peoples
//             join ct in dataContext.Cities on p.CityId equals ct.Id
//             join c in dataContext.Countries on ct.CountryId equals c.Id
//             select new 
//             {
//                 Person = p,
//                 City = ct,
//                 Country = c
//             } 
//     );

//     foreach (var item in query)
//     {
//         System.Console.WriteLine($"Person First Name: {item.Person.FirstName} Last Name: {item.Person.LastName} City Name: {item.City.Name} Country Name: {item.Country.Name}");
//     }

//9
//Получить всех людей, живущих в "USA".
//Retrieve all people living in  "USA".

// var query = 
//     from p in dataContext.Peoples
//     join ct in dataContext.Cities on p.CityId equals ct.Id
//     join c in dataContext.Countries on ct.CountryId equals c.Id
//     where c.Name == "USA"
//     select p;

//     foreach (var item in query)
//     {
//         System.Console.WriteLine($"ID: {item.Id} Name:{item.FirstName} {item.LastName}");
//     }


//10
//Получить всех людей вместе с соответствующим населением города и страны
//Retrieve all people along with their associated city and country populations 
// var query = (from p in dataContext.Peoples
//             join ct in dataContext.Cities on p.CityId equals ct.Id
//             select new
//             {
//                 Person = p,
//                 CityPopulation = ct.Population,
//                 CityName = ct.Name
//             }
// );

// foreach (var item in query)
// {
//     System.Console.WriteLine($" City :{item.CityName} Population: {item.CityPopulation} Person Name: {item.Person.FirstName}");
// }




