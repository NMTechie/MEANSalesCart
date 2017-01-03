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