var app = angular.module("SalesCartAppModule",[]);

app.constant("AUTHENTICATION_STATE",{
  loginSuccess: "auth-login-success",
  loginFailed: "auth-login-failed",
  logoutSuccess: "auth-logout-success",
  sessionTimeout: "auth-session-timeout",
  notAuthenticated: "auth-not-authenticated",
  notAuthorized: "auth-not-authorized"
}
);

app.factory("SESSION_STORE_SERVICE",function(){
	var sessionService = {};
	//
	sessionService.Save = function(identifier,dataToSave){
		sessionStorage.setItem(identifier, dataToSave);
	}
	//
	sessionService.GetValue = function(){
		return sessionStorage.getItem(identifier);
	}
	//
	sessionService.Remove = function(identifier){
		sessionStorage.removeItem(identifier);
	}
	//
	sessionService.RemoveAll = function(){
		sessionStorage.clear();
	}
	return sessionService;
}
);
app.value('AUTH_URL','http://localhost:63171/MyWebApi/user/Validateuser');
 