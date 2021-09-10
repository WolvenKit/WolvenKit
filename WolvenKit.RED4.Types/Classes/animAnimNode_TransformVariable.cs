using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_TransformVariable : animAnimNode_TransformValue
	{
		[Ordinal(11)] 
		[RED("variableName")] 
		public CName VariableName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public animAnimNode_TransformVariable()
		{
			Id = 4294967295;
		}
	}
}
