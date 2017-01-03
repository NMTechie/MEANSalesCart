app.controller("loginController",function($scope,AUTHENTICATION_STATE)
{
	alert(AUTHENTICATION_STATE.loginSuccess);
}
);