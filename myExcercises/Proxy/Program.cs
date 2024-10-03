Studio studio = new Studio("Hollywood Studio");

SecurityProxy security = new SecurityProxy(studio); 

Visitor v1 = new Visitor(security, true);
Visitor v2 = new Visitor(security, true);
Visitor v3 = new Visitor(security, false);
Visitor v4 = new Visitor(security, false);



v1.AttemptToEnter();
v4.AttemptToEnter();