using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_IntToFloatConverter : animAnimNode_FloatValue
	{
		[Ordinal(1)] 
		[RED("inputNode")] 
		public animIntLink InputNode
		{
			get => GetPropertyValue<animIntLink>();
			set => SetPropertyValue<animIntLink>(value);
		}

		public animAnimNode_IntToFloatConverter()
		{
			Id = uint.MaxValue;
			InputNode = new animIntLink();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
