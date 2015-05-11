/*
 * Created by SharpDevelop.
 * User: Goofy
 * Date: 5/9/2015
 * Time: 1:08 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Trakt.Api.V2.Trakt.Calendars.GetShows
{
	/// <summary>
	/// Description of Show.
	/// </summary>
	public class Show
	{
		public string title { get; set; }
    	public int year { get; set; }
    	public ShowIds ids { get; set; }
		
		public Show()
		{
		}
	}
}
