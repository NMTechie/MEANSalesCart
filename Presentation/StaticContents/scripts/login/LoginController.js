/*
*	In the below controller there are 3 dependencies.
*	$scope - > child scope object created by the angular framework
*	AUTHENTICATION_STATE -> service (which in turn object) created through  constant receipe
*	AUTHENTICATION_SERVICE -> service (which in turn object) created through  factory receipe

*	Controller initiate first and then view has been rendered, thus need to define the "credential" object first
*	that has been used in the view later
*/
app.controller("loginController",function($scope,AUTHENTICATION_STATE,AUTHENTICATION_SERVICE)
{
	$scope.credential = {
		userid : "",
		password : ""
	};
	$scope.Validate = function(userCredential){
		alert(userCredential.userid);
		alert(userCredential.password);
	}
	alert(AUTHENTICATION_SERVICE);
}
);

/*
*
*/
app.factory("AUTHENTICATION_SERVICE",function(AUTHENTICATION_STATE){
		return AUTHENTICATION_STATE.loginSuccess+" for Nilesh";
}
);