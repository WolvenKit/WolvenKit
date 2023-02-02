using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_FloatToBoolConverter : animAnimNode_BoolValue
	{
		[Ordinal(11)] 
		[RED("inputNode")] 
		public animFloatLink InputNode
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		public animAnimNode_FloatToBoolConverter()
		{
			Id = 4294967295;
			InputNode = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
