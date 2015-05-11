/*
 * Created by SharpDevelop.
 * User: Goofy
 * Date: 5/9/2015
 * Time: 9:32 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Trakt.Api.V2.Trakt.Authentication.Token
{
	/// <summary>
	/// Description of ExchangeRefreshTokenForAccessTokenRequest.
	/// </summary>
	public class ExchangeRefreshTokenForAccessTokenRequest
	{
		public string refresh_token { get; set; }
    	public string client_id { get; set; }
    	public string client_secret { get; set; }
    	public string redirect_uri { get; set; }
    	public string grant_type { get; set; }
		
		public ExchangeRefreshTokenForAccessTokenRequest(string refresh_token, string client_id, string client_secret, string redirect_uri)
		{
			this.refresh_token = refresh_token;
			this.client_id = client_id;
			this.client_secret = client_secret;
			this.redirect_uri = redirect_uri;
			this.grant_type = "refresh_token";
		}
	}
}
