﻿using System;
using System.Collections.Generic;

namespace System.Maui.Samples
{
	public class TextFieldSample2 : View
	{
		readonly State<string> _textValue = "Edit Me";

		[Body]
		View body() => new VStack()
		{
			new TextField(_textValue, "Name"),
			new HStack()
			{
				new Text("Current Value:")
					.Color(Color.Grey),
				new Text(_textValue),
				new Spacer()
			},
		}.FillHorizontal();
	}

}
