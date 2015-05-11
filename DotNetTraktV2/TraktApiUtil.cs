/*
 * Created by SharpDevelop.
 * User: Goofy
 * Date: 5/8/2015
 * Time: 10:04 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Net;
using System.Text;

namespace Trakt.Api.V2
{
	/// <summary>
	/// Description of HttpsUtil.
	/// </summary>
	public static class TraktApiUtil
	{
		private static readonly string TRAKT_API_URL = "https://api-v2launch.trakt.tv";
		private static readonly string TRAKT_API_VERSION = "2";

		public static string getUrl(string url) {			
			return getUrl(url, null);
		}
		
		public static string getUrl(string url, string trakt_api_key) {			
			return getUrl(url, trakt_api_key, null);
		}
		
		public static string getUrl(string url, string trakt_api_key, string access_token) {
			return getUrl(url, trakt_api_key, access_token, true);
		}
		
		public static string getUrl(string url, string trakt_api_key, string access_token, bool prependTraktApiUrl) {
			if (prependTraktApiUrl)
				url = TRAKT_API_URL + url;
			WebRequest webRequestGet = WebRequest.Create(url);
			webRequestGet.ContentType = "application/json";
			webRequestGet.Headers.Add("trakt-api-version", TRAKT_API_VERSION);
			if (trakt_api_key != null)
				webRequestGet.Headers.Add("trakt-api-key", trakt_api_key);
			if (access_token != null)
				webRequestGet.Headers.Add("Authorization", "Bearer " + access_token);

			Stream objStream = webRequestGet.GetResponse().GetResponseStream();

			string value;
			using(StreamReader objReader = new StreamReader(objStream))
			{
				value = objReader.ReadToEnd();
			}
			
			return value;
		}		
		
		public static string postUrl(string url, string post_data) {
			return postUrl(url, post_data, true);
		}
		
		public static string postUrl(string url, string post_data, bool prependTraktApiUrl)
		{
			if (prependTraktApiUrl)
				url = TRAKT_API_URL + url;
			WebRequest webRequestPost = WebRequest.Create(url);
			webRequestPost.ContentType = "application/json";
			webRequestPost.Method = "POST";
			byte[] byteArray = Encoding.UTF8.GetBytes(post_data);
			webRequestPost.ContentLength = byteArray.Length;
			using(Stream dataStream = webRequestPost.GetRequestStream())
			{
				dataStream.Write(byteArray, 0, byteArray.Length);
			}
			
			Stream objStream = webRequestPost.GetResponse().GetResponseStream();

			string value;
			using(StreamReader objReader = new StreamReader(objStream))
			{
				value = objReader.ReadToEnd();
			}
			
			return value;
		}
	}
}
