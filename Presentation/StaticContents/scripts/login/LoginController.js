/*
*	In the below controller there are 3 dependencies.
*	$scope - > child scope object created by the angular framework
*	AUTHENTICATION_STATE -> service (which in turn object) created through  constant receipe
*	AUTHENTICATION_SERVICE -> service (which in turn object) created through  factory receipe
*/
app.controller("loginController",function($scope,AUTHENTICATION_STATE,AUTHENTICATION_SERVICE)
{
	alert(AUTHENTICATION_STATE.loginSuccess);
}
);

/*
*
*/
app.factory("AUTHENTICATION_SERVICE",function(AUTHENTICATION_STATE){
	alert(AUTHENTICATION_STATE.loginFailed);
	return AUTHENTICATION_STATE.loginFailed;
}
);