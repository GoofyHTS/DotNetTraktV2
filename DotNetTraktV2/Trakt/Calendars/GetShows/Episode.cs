/*
 * Created by SharpDevelop.
 * User: Goofy
 * Date: 5/9/2015
 * Time: 1:06 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Trakt.Api.V2.Trakt.Calendars.GetShows
{
	/// <summary>
	/// Description of Episode.
	/// </summary>
	public class Episode
	{
		public int season { get; set; }
    	public int number { get; set; }
    	public string title { get; set; }
    	public Ids ids { get; set; }
		
		public Episode()
		{
		}
	}
}
