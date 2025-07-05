using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_BoolToFloatConverter : animAnimNode_FloatValue
	{
		[Ordinal(11)] 
		[RED("inputNode")] 
		public animBoolLink InputNode
		{
			get => GetPropertyValue<animBoolLink>();
			set => SetPropertyValue<animBoolLink>(value);
		}

		public animAnimNode_BoolToFloatConverter()
		{
			Id = uint.MaxValue;
			InputNode = new animBoolLink();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
