using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_BoolJoin : animAnimNode_BoolValue
	{
		[Ordinal(11)] 
		[RED("input")] 
		public animBoolLink Input
		{
			get => GetPropertyValue<animBoolLink>();
			set => SetPropertyValue<animBoolLink>(value);
		}

		public animAnimNode_BoolJoin()
		{
			Id = uint.MaxValue;
			Input = new animBoolLink();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
