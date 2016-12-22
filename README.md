Input

The following routes are available for this service:
All Verbs	/ttf/{MappingType}

### For missing input parameters, respective default values of "0" and "false" will be assumed for int and bool types
Input Parameters:
NAME |	PARAMETER |	DATA TYPE |	REQUIRED | DESCRIPTION
--- | --- | --- | --- | --- |
A |	query |	bool |	No | |
B |	query |	bool |	No |	|
C |	query |	bool |	No | |
D |	query |	int |	No |	|
E |	query |	int |	No | |
F |	query |	int |	No |	|
MappingType |	path |	string |	Yes |	Mapping algorithm to be used
Allowable Values

Base
Specialized1
Specialized2 |

Output Parameters:
NAME	PARAMETER	DATA TYPE	REQUIRED	DESCRIPTION
X	form	X	No	
Y	form	double	No	

HTTP + JSON
The following are sample HTTP requests and responses. The placeholders shown need to be replaced with actual values.

POST /ttf/base?format=json HTTP/1.1 
Host: localhost 
Content-Type: application/json
Content-Length: length

{"A":true,"B":true,"C":false,"D":0,"E":0,"F":0}
HTTP/1.1 200 OK
Content-Type: application/json
Content-Length: length

{"X":"S","Y":0}