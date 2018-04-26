
# Extensor 
Extension methods for the everyday C# developer!  
[Nuget.org package](https://www.nuget.org/packages/Extensor/)   

| branch | master                                                                                                                       | dev                                                                                                                          |
|--------|------------------------------------------------------------------------------------------------------------------------------|------------------------------------------------------------------------------------------------------------------------------|
| build status | ![Build Status](https://jrsosa.visualstudio.com/_apis/public/build/definitions/ae28eed0-7e27-4299-a8d7-89ef8b8e0df5/6/badge) | ![Build Status](https://jrsosa.visualstudio.com/_apis/public/build/definitions/ae28eed0-7e27-4299-a8d7-89ef8b8e0df5/7/badge) |  


	
  ## Inspiration  
	
Every time we start a new project we tend to find ourselves writing the same conditional "checkers" to improve our source code. Ever wrote something like this?  


```csharp  

public bool CheckIfListHasItem(string[] somevals, string value)
        {
            if (somevals == null)
            {
                throw new System.ArgumentNullException(nameof(somevals));
            }

            for (int i = 0; i < somevals.Length; i++)
            {
                if (somevals[i].Equals(value))
                    return true;
            }

            return false;
        }
```  
Long right? What if we can do better with an extension method?     


```csharp  
  public static bool In(this string v, params string[] values) => values.Contains(v);
```  
**WHOA!**    
Usage?  
```csharp  
 //some random values
 values = new string[] { "extensor", "jrsosadev", "puertorico", "android" };  
 //check
 return "android".In(values);  
 ```  
Simple and clean! :)  

The .NetFramework provides a series of standard ExtensionMethods already such as `Single` `Concat` and so on most of them introduced when we first got extension methods in 2007 ! (C# 3.0) .
**Extensor** aims to take it further by adding additional methods that make developers focus on **building more and writing less**  

Need a CSV mask to print out those customer name? No problem Extensor has you covered with the `ToCommaSeparatedValues` method.  
```csharp    
var names = new string[] { "batman", "ironman", "catwoman" };

//this
Console.Write(names.ToCommaSeparatedValues());  

//prints out
"batman,ironman,catwoman"
```
  

## Common Questions  

**Do I really need Extensor?**  
It depends, although Extensor contains lots of useful and tested Extension methods I know that as the project size increases the amount of methods you might need may become irrelevant, this is why the project uses the MIT license so you can go ahead and copy the implementations you need without issues :)  

**Are extension tested?**  
Yes, every extension method has at least one unit test.

**I see its listed on Nuget how often will you release new versions?**  
Hopefully if time permits once a month or as needed. 

**Can I contribute?**  
Fork the project, develop on dev and submit a pull request! Everything is on the contribution guide.  

**How do you build the nuget package?**  
Currently there is a Visual Studio Team Services project that takes care of the `Build` `Test` and `Deployment`  the last one only happens when a pull request is done to the `master` branch of the repo.  I designed it this way so that everyone can do pull requests on dev without worrying about breaking `master`  

**Does CI gets triggered upon a pull request?**  
Absolutely, when you open a pull request you trigger a `build` and `test` process that unless it passes a merge cannot be made.   


License
-------  

MIT License

Copyright (c) 2018 Joel R. Sosa

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.








