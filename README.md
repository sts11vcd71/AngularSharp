AngularSharp
============

UI Framework and CMS Based on AngularJS and WebAPI (ASP.NET): No more logic duplication on client and server side;
Most of javascript code is generated from .NET

---------------------------------
Planned Features
---------------------------------
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
- The MODEL
    - have 3 collections in server Old, New and Actual from DB to allow writing extended logic (Rules) which can take into account
      the concurrency updated values and previous value of the control. Allow to turn off this feature.
    - Post only differences from client to server (angular js has ability to identify what exactly was changed) and apply those differences 
      to the collections stored in server.
    - Maybe MongoDB should be used to store collection for current view state. (this can be decided for particular view 
      whether MODEL caching is needed)
- Use NodeJS for processing AngularJS templates for multilanguage filters on server (but process only those things 
  which marked by some server tag). this is needed for performance. We also need to cache those templates for different 
  user settings.
- MVVM
    - UI will be always a representation of the MODEL mapped to view
    - Views will be partial (describing some specific part of the application)
    - View can be bind to MODEL on server and on client (some binding will be on server and some on client)
    - Views can be cached for better performance, based on some parameters (included to the MODEL, e.g. /RootModel/LanguageCode etc)
      Cached view is stored on hard drive and valid for some period. For example this can be used for different languages.
      
- RULES ENGINE
    - Developer can decide which nodes of the MODEL he want to expose to client (included into client MODEL, JSON serialized and 
      retunrned to client object tree). Also he could decide which Rule will be executed on server only (with the special marking 
      to this rule) in that case rule should not be serialized to javascript. If there are pure server rules they should be executed 
      on server. 
    - We will have 2 sides where the rules can be executed (client and server)
    - We will have 2 sides where the template can be processed (client and server)
    - In general (not matter which rules executed where on client or on client+server) they all need to keep application consistent
- MODULES
    - Is a set of Views and Rules. Modules can't affect existing rules for other modules but can extend the rules set. 
    - 

---------------------------------
MODEL SAMPLE (from the ROOT)
---------------------------------
- SitePage
    - Title
    - Scripts[]
    - SiteMenuItem         (<- FrontPage)
        - ChildItems[]
            - SiteMenuItem1
                - Title
                - Action
            - SiteMenuItem2
                - Title
                - Action
    - ActiveSiteMenuItem    (<- UI template will be loaded based on this value)
  
---------------------------------
APPROACHING AND PLANNING
---------------------------------
- Analyze actual DOM after AngularJS (use JetBrains IDE Support Chrome extension for that) and make possible to distinguish server template binding logic out from client 
template binding
- Engine which serializes object to JSON should be smart enough to allow serializing a) only selected items b) all items except selected
  This will allow us to support partial binding Model to View on server and then on client. As well as caching (to cache some view 
  it should be partially bind). It should also allow to merge full MODEL with partial model received from client for example.
- 
USE Edge.js and Node.js