﻿using System;

namespace TodoAWSSimpleDB
{
	public static class Constants
	{
		// AWS
		// Sign up for an AWS account at https://aws.amazon.com/
		// Configure at https://console.aws.amazon.com/cognito/
		public static string CognitoIdentityPoolId = "";

		// OAuth
		// For Google login, configure at https://console.developers.google.com/
		public static string ClientId = "";
		public static string ClientSecret = "";

		// These values do not need changing
		public static string Scope = "https://www.googleapis.com/auth/userinfo.email";
		public static string AuthorizeUrl = "https://accounts.google.com/o/oauth2/auth";
		public static string AccessTokenUrl = "https://accounts.google.com/o/oauth2/token";
		public static string UserInfoUrl = "https://www.googleapis.com/oauth2/v2/userinfo";

		// Set this property to the location the user will be redirected too after successfully authenticating
		public static string RedirectUrl = "http://blank.org";
	}
}
