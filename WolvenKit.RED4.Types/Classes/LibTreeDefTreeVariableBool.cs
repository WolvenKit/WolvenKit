using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LibTreeDefTreeVariableBool : LibTreeDefTreeVariableBoolBase
	{
		[Ordinal(2)] 
		[RED("exportAsProperty")] 
		public CBool ExportAsProperty
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("defaultValue")] 
		public CBool DefaultValue
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public LibTreeDefTreeVariableBool()
		{
			Id = 65535;
			ReadableName = "TreeVar";
			ExportAsProperty = true;
		}
	}
}
