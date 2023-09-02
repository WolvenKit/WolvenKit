using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_IntJoin : animAnimNode_IntValue
	{
		[Ordinal(11)] 
		[RED("input")] 
		public animIntLink Input
		{
			get => GetPropertyValue<animIntLink>();
			set => SetPropertyValue<animIntLink>(value);
		}

		public animAnimNode_IntJoin()
		{
			Id = uint.MaxValue;
			Input = new animIntLink();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
