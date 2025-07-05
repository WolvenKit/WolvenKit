using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_FloatJoin : animAnimNode_FloatValue
	{
		[Ordinal(11)] 
		[RED("input")] 
		public animFloatLink Input
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		public animAnimNode_FloatJoin()
		{
			Id = uint.MaxValue;
			Input = new animFloatLink();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
