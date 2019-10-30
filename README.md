# BetEasy

Please, before run the project or unit test, fix the path of the source files to your correspondent computer path.


jsonSource: @"..\dotnet-code-challenge\FeedData\Wolferhampton_Race1.json"


xmlSource:  @"..\dotnet-code-challenge\FeedData\Caulfield_Race1.xml"


And it should be ok to Run.


##Improvements to make


- Split concerns of Race Repository to two different classes from two different sources. (Dependency Inversion and Interface Segregation)


- Find a better way to load data sources from the local computer without fix paths manually.


- Mock tests to each method instead only from the main one.

