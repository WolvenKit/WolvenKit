using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_QuaternionJoin : animAnimNode_QuaternionValue
	{
		[Ordinal(11)] 
		[RED("input")] 
		public animQuaternionLink Input
		{
			get => GetPropertyValue<animQuaternionLink>();
			set => SetPropertyValue<animQuaternionLink>(value);
		}

		public animAnimNode_QuaternionJoin()
		{
			Id = uint.MaxValue;
			Input = new animQuaternionLink();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
