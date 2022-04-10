Instructions
1. open web.config update connectionString key value
2. run all sql scripts (see SqlScripts folder)  - replace USE <DrorTest> with your DB name
3. run WebApi sln file 
4. get or post the requests using the following:
  
    first question: GET request for   http://localhost:<port>/api/Query/FirstQuery?year=2020
   secont question: POST request for   http://localhost:<port>/api/Query/SecondQuery  ,with row json param: {"list":"A002,A009", "orderNum":2 }
   third question: POST request for   http://localhost:<port>/api/Query/ThirdQuery  , with row json param: {"number":2, "year":2020 }