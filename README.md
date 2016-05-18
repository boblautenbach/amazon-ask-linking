# Amazon Echo Skill Linking with Azure .Net Back End

Many Thanks to TAISEER.  This project lifted heavily from [his series of articles](http://bitoftech.net/2014/07/16/enable-oauth-refresh-tokens-angularjs-app-using-asp-net-web-api-2-owin/) on Azure and Oauth

The simplest way to use and play with this project is to:

Download zip/clone it

Set the ngWeblogin and OAuth.api projects to startup at same time

You will need to modify the url strings in authService.js and loginController.js to point to you test url/port

Once the urls are correct and both projects are started, click the Login link on the ngLogin page, which is mimic a redirect from amazon.

Login as test@oauth.com with pwd = password

You will be mock-redirected (mimicing going back to Amazon after a login).  The URL will contain the token you need.




