﻿using System;
using HotUI.Samples.Models;

namespace HotUI.Samples {
	public class ListViewDetails : View {
		[State]
		readonly Song song;
		public ListViewDetails (Song song)
		{
			this.song = song;
			Body = () => new VStack {
				new Image(() => song.ArtworkUrl),
				new Text(() => song.Title),
				new Text(() => song.Artist),
				new Text(() => song.Album),
			};
		}
	}
}
