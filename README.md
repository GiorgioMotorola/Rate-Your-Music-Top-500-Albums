# Rate-Your-Music-Top-500-Albums

http://www.Rateyourmusic.com is one of the largest music databases and communities online. Users can sign up and rate albums they have listened to between 1-5 stars. 
I located a .tsv file off of https://data.world/notgibs/rateyourmusic-top500-albums and converted it to a .JSON file. In order to demonstrate making a RESTful API call, 
I put the .JSON file in a Git Hub repository. The program receives the .JSON response body and then deserializes it to allow the user to parse thru the data.

```
string url = "https://raw.githubusercontent.com/GiorgioMotorola/Rate-Your-Music-Top-500-JSON/main/JSON";
            HttpClient client = new HttpClient();
```
