using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_BoolVariable : animAnimNode_BoolValue
	{
		[Ordinal(11)] 
		[RED("variableName")] 
		public CName VariableName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public animAnimNode_BoolVariable()
		{
			Id = 4294967295;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
