# amazon-ask-linking

Download zip/clone it

Set the ngWeblogin and OAuth.api projects to startup at same time

You will need to modify the url strings in authService.js and loginController.js to point to you test url/port

Once the urls are correct and both projects are started, click the Login link on the ngLogin page, which is mimic a redirect from amazon.

Login as bob@braneworks.com with pwd = password

You will be mock-redirected (mimicing going back to Amazon after a login).  The URL will contain the token you need.


