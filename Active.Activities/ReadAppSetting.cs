﻿using System.Activities;
using System.ComponentModel;
using System.Configuration;

namespace Active.Activities
{
	public class ReadAppSetting : CodeActivity
	{
		[RequiredArgument]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		[Browsable(true)]
		[Description("The name of the app setting of the current running application to read.")]
		[Category("Input")]
		public InArgument<string> AppSettingName { get; set; }

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		[Browsable(true)]
		[Description("The value of the specified app setting entry.")]
		[Category("Output")]
		public OutArgument<string> Value { get; set; }

		protected override void Execute(CodeActivityContext context)
		{
			Value.Set(context, ConfigurationManager.AppSettings[AppSettingName.Get(context)]);
		}
	}
}
