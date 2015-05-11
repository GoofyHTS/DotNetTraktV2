/*
 * Created by SharpDevelop.
 * User: Goofy
 * Date: 5/9/2015
 * Time: 9:33 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Trakt.Api.V2.Trakt.Authentication.Token
{
	/// <summary>
	/// Description of ExchangeRefreshTokenForAccessTokenResponse.
	/// </summary>
	public class ExchangeRefreshTokenForAccessTokenResponse
	{
		public string access_token { get; set; }
    	public string token_type { get; set; }
    	public int expires_in { get; set; }
    	public string refresh_token { get; set; }
    	public string scope { get; set; }
		
		public ExchangeRefreshTokenForAccessTokenResponse()
		{
		}
	}
}
