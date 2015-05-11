/*
 * Created by SharpDevelop.
 * User: Goofy
 * Date: 5/9/2015
 * Time: 1:04 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using Trakt.Api.V2.Trakt.Calendars.GetShows;

namespace Trakt.Api.V2.Trakt.Calendars.GetShows
{
	/// <summary>
	/// Description of GetNewShows.
	/// </summary>
	public class GetShows
	{
		public string first_aired { get; set; }
    	public Episode episode { get; set; }
    	public Show show { get; set; }
		
		public GetShows()
		{
		}
	}
}
