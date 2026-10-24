using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_FloatToBoolConverter : animAnimNode_BoolValue
	{
		[Ordinal(1)] 
		[RED("inputNode")] 
		public animFloatLink InputNode
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		public animAnimNode_FloatToBoolConverter()
		{
			Id = uint.MaxValue;
			InputNode = new animFloatLink();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
