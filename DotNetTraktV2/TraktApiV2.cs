/*
 * Created by SharpDevelop.
 * User: Goofy
 * Date: 5/8/2015
 * Time: 9:47 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Trakt.Api.V2.Trakt.Authentication.Token;
using Trakt.Api.V2.Trakt.Calendars.GetShows;

namespace Trakt.Api.V2
{
	/// <summary>
	/// Description of TraktApiV2.
	/// </summary>
	public class TraktApiV2
	{	
		
		public string client_id {get; set;}
		public string client_secret {get; set;}
		public string redirect_uri {get; set;}
		public string access_token {get; set;}
		
		public TraktApiV2(string client_id, string client_secret, string redirect_uri)
		{
			this.client_id = client_id;
			this.client_secret = client_secret;
			this.redirect_uri = redirect_uri;
		}
		
		public string AuthorizeApplication(string redirect_url, string state)
		{
			StringBuilder urlBuilder = new StringBuilder("https://trakt.tv/oauth/authorize?response_type=code&client_id=");			
			urlBuilder.Append(this.client_id);
			if (redirect_url != null)
			{
				urlBuilder.Append("&redirect_uri=");
				urlBuilder.Append(redirect_url);
			}
			if (state != null)
			{
				urlBuilder.Append("&state=");
				urlBuilder.Append(state);
			}
			
			return urlBuilder.ToString();
		}
		
		public ExchangeCodeForAccessTokenResponse ExchangeCodeForAccessToken(string code)
		{
			const string url = "/oauth/token";
			ExchangeCodeForAccessTokenRequest exchangeCodeForAccessTokenRequest = new ExchangeCodeForAccessTokenRequest(code, this.client_id, this.client_secret, this.redirect_uri);
			
			string jsonRequest = JsonConvert.SerializeObject(exchangeCodeForAccessTokenRequest);
			
			string jsonResponse = TraktApiUtil.postUrl(url, jsonRequest);
			
			return JsonConvert.DeserializeObject<ExchangeCodeForAccessTokenResponse>(jsonResponse);
		}
		
		public ExchangeRefreshTokenForAccessTokenResponse ExchangeRefreshTokenForAccessToken(string refresh_token)
		{
			const string url = "/oauth/token";
			
			ExchangeRefreshTokenForAccessTokenRequest exchangeRefreshTokenForAccessTokenRequest = new ExchangeRefreshTokenForAccessTokenRequest(refresh_token, this.client_id, this.client_secret, this.redirect_uri);
			
			string jsonRequest = JsonConvert.SerializeObject(exchangeRefreshTokenForAccessTokenRequest);
			
			string jsonResponse = TraktApiUtil.postUrl(url, jsonRequest);
			
			return JsonConvert.DeserializeObject<ExchangeRefreshTokenForAccessTokenResponse>(jsonResponse);
		}
		
		public List<GetShows> GetShows()
		{			
			return GetShows(null,null);
		}
		
		public List<GetShows> GetShows(string startDate)
		{		
			return GetShows(startDate, null);			
		}
		
		public List<GetShows> GetShows(string startDate, int? days)
		{			
			StringBuilder urlBuilder = new StringBuilder("/calendars/my/shows");
			if (startDate != null)
				urlBuilder.Append("/" + startDate);
			if (days != null)
				urlBuilder.Append("/" + days);
			
			string json = TraktApiUtil.getUrl(urlBuilder.ToString(), this.client_id, this.access_token);
			
			return JsonConvert.DeserializeObject<List<GetShows>>(json);
		}
	}
}