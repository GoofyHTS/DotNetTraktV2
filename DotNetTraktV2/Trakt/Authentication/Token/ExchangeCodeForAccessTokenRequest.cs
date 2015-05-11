/*
 * Created by SharpDevelop.
 * User: Goofy
 * Date: 5/9/2015
 * Time: 8:55 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Trakt.Api.V2.Trakt.Authentication.Token
{
	/// <summary>
	/// Description of ExchangeCodeForAccessToken.
	/// </summary>
	public class ExchangeCodeForAccessTokenRequest
	{
		public string code { get; set; }
    	public string client_id { get; set; }
    	public string client_secret { get; set; }
    	public string redirect_uri { get; set; }
    	public string grant_type { get; set; }
		
		public ExchangeCodeForAccessTokenRequest(string code, string client_id, string client_secret, string redirect_uri)
		{
			this.code = code;
			this.client_id = client_id;
			this.client_secret = client_secret;
			this.redirect_uri = redirect_uri;
			this.grant_type = "authorization_code";
		}
	}
}
