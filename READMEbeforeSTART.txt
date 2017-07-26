--------------------------------------------------------------------------------------------------------
GIT
--------------------------------------------------------------------------------------------------------
First you need to install the GIT for windows which is the client for GitHub.
Then install TortoiseGit which provides the windows shell for it.

Tortoise Git info :- 
1. https://tortoisegit.org/docs/tortoisegit/tgit-dug-settings.html#tgit-dug-settings-git


The proxy settings :- 
1. http://stackoverflow.com/questions/18356502/github-failed-to-connect-to-github-443-windows-failed-to-connect-to-github

2. http://stackoverflow.com/questions/16153450/github-windows-client-behind-proxy

detect proxy settings :- run the command:- reg query "HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentV
ersion\Internet Settings" | find /i "proxyserver"

In Cognizant machine the path is "C:\Users\152089\.gitconfig".
-----------------------------------------------------------------------------------------------------------------------------
Angular.js
-----------------------------------------------------------------------------------------------------------------------------
	Any angular app is a collaboration of different objects which are been created by Injector Service.
	Injector Service creates the objects through registered receipe.
	Five types of receipes are 
					1. Value
					2. Constant
					3. Service
					4. Factory
					5. Provider
