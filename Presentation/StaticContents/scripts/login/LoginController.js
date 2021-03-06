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
		AUTHENTICATION_SERVICE.Login(userCredential);
	}	
}
);

/*
*
*/
app.factory("AUTHENTICATION_SERVICE",function($http,AUTH_URL,SESSION_STORE_SERVICE){
/*The authService is the object instance which will be return as service from this factory receipe*/
		var authService = {};
		authService.Login = function(userCredential)
		{	
			$http.post(AUTH_URL,userCredential).then(function succValidate(response)
			{
				SESSION_STORE_SERVICE.Save(response.data.id,userCredential.userid);
				alert(response.status);
			}
			,
			function errValidate(response)
			{
				alert(response.status);
			});
		}
		return authService;
}
);