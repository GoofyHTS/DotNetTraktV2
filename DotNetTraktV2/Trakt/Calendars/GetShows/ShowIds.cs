/*
 * Created by SharpDevelop.
 * User: Goofy
 * Date: 5/9/2015
 * Time: 1:07 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Trakt.Api.V2.Trakt.Calendars.GetShows
{
	/// <summary>
	/// Description of Ids2.
	/// </summary>
	public class ShowIds
	{
		public int trakt { get; set; }
    	public string slug { get; set; }
    	public int tvdb { get; set; }
    	public string imdb { get; set; }
    	public int tmdb { get; set; }
    	public int tvrage { get; set; }
		
		public ShowIds()
		{
		}
	}
}
