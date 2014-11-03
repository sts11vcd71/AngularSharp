AngularSharp
============

UI Framework Based on AngularJS and WebAPI (ASP.NET): No more logic duplication on client and server side;
Most of javascript code is generated from .NET

Planned Features
----------------
- AngularJS based views
	- Polymorphic controls to allow changes driven by metadata
- The MODEL will contain metadata along with data, which will help to manipulate types of controls: 
	Readonly, input type (dropdown list multiselect, textbox), possible values range etc.
- The whole MODEL can be created on C# and pulled via WebAPI to javascript
- Parts of the MODEL can be updated by demand when some part of view is switched 
- There is no events or actions in the framework: To keep everything in application consistent there two things 
which drives:
	- Rules Engine: Rules, created in C# with LINQ expressions will be able to be executed both on Server and on Client. 
		Javascript code will be generated from the existing C# rules. 
	- Finite-State Machine: buttons will be switching the state of the current View

MODEL
-----
- SitePage
	- Title
	- Scripts[]
	- SiteMenu[]
		- SiteMenuItem1
			- Title
			- Action
		- SiteMenuItem2
			- Title
			- Action
