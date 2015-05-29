/*
 * Created by SharpDevelop.
 * User: Goofy
 * Date: 5/29/2015
 * Time: 9:46 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using KitsuneDotNet.Attributes;
using Trakt.Api.V2.Trakt.Authentication.Token;
using Trakt.Api.V2.Trakt.Calendars.GetShows;

namespace DotNetTraktV2.Trakt
{
	/// <summary>
	/// Description of TraktV2Api.
	/// </summary>
	[RequestHeader("trakt-api-version", "2")]	
	[RequestHeader("trakt-api-key", "{trakt-api-key}")]
	public interface TraktV2Api
	{
		[StaticResponse("https://trakt.tv/oauth/authorize?response_type=code&client_id={trakt-api-key}&redirect_uri=urn:ietf:wg:oauth:2.0:oob")]
		string AuthorizeApplication();
		
		[Post("/oauth/token", "request")]
		ExchangeCodeForAccessTokenResponse ExchangeCodeForAccessToken(ExchangeCodeForAccessTokenRequest request);
		
		[Get("/calendars/my/shows/{start_date}/{days}")]
		GetShowsResponse GetShows(string start_date, int days);
		
		[Get("/shows/{id}/seasons/{season}")]
		string GetSingleSeasonForAShow(string id, int season);
		
		[Get("/users/settings")]
		[RequestHeader("Authorization","Bearer {accessToken}")]
		string RetrieveSettings();
	}
}
