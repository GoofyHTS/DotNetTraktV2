﻿/*
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
	/// Description of Ids.
	/// </summary>
	public class Ids
	{
		public int trakt { get; set; }
    	public int tvdb { get; set; }
    	public string imdb { get; set; }
    	public int tmdb { get; set; }
    	public object tvrage { get; set; }
		
		public Ids()
		{
		}
	}
}
