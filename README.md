Input

The following routes are available for this service:
All Verbs	/ttf/{MappingType}		
Input Parameters:
NAME	PARAMETER	DATA TYPE	REQUIRED	DESCRIPTION
A	query	bool	No	
B	query	bool	No	
C	query	bool	No	
D	query	int	No	
E	query	int	No	
F	query	int	No	
MappingType	path	string	Yes	Mapping algorithm to be used
Allowable Values

Base
Specialized1
Specialized2
Output Parameters:
NAME	PARAMETER	DATA TYPE	REQUIRED	DESCRIPTION
X	form	X	No	
Y	form	double	No	
To override the Content-type in your clients, use the HTTP Accept Header, append the .json suffix or ?format=json

To embed the response in a jsonp callback, append ?callback=myCallback

HTTP + JSON
The following are sample HTTP requests and responses. The placeholders shown need to be replaced with actual values.

POST /json/reply/Input HTTP/1.1 
Host: localhost 
Content-Type: application/json
Content-Length: length

{"A":false,"B":false,"C":false,"D":0,"E":0,"F":0,"MappingType":"String"}
HTTP/1.1 200 OK
Content-Type: application/json
Content-Length: length

{"X":"S","Y":0}