STEPS to RUN the application - 
  •	git clone  https://github.com/gourav8jain/CountryGwpAPIRun
  •	This solution in Visual studio or run it through command prompt
  •	Once web-API is running, open the URL - http://localhost:9091/swagger/index.html
  •	Call the API using Swagger - POST API - http://localhost:9091/server/api/gwp/avg
  •	REQUEST Body (e.g.)- 
        {
          "country": "ae",
          "lineOfBusiness": [
            "transport","freight"
          ]
        }
        
  •	RESPONSE Body (e.g.)- 
        {
          "transport": [
            249495209.6625
          ],
          "freight": [
            234056430.6625
          ]
      }

Things covered apart from the WEB API logic and basic implementation - 
  •	NUnit Test Cases on controller level (was running short of time)
  •	Calls are ASYNC
  •	SOLID followed
  •	User-defined exception handling is in place on the solution level
  •	Swagger GUI is implemented
  •	Caching and Repository pattern was not required as I read the data from CSV which was pretty fast
