RestService1

Developed with Visual Studio 2015

Use "View in Browser" to test the app.

WCF Service operations (Uses URI query, BAD DESIGN because it exposes the actual service operation rather than the Resource, which leads to a coupling problem. In otherwords this is not truly best practice RESTful design.)

http://localhost:60001/Service.svc/SecretNumber?lower=0&upper=10

http://localhost:60001/Service.svc/CheckNumber?userNum=4&SecretNum=5
“too small”

http://localhost:60001/Service.svc/CheckNumber?userNum=5&SecretNum=5
“correct”

http://localhost:60001/Service.svc/CheckNumber?userNum=6&SecretNum=5
“too big”
