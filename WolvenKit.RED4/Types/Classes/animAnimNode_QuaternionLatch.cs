using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_QuaternionLatch : animAnimNode_QuaternionValue
	{
		[Ordinal(11)] 
		[RED("input")] 
		public animQuaternionLink Input
		{
			get => GetPropertyValue<animQuaternionLink>();
			set => SetPropertyValue<animQuaternionLink>(value);
		}

		public animAnimNode_QuaternionLatch()
		{
			Id = uint.MaxValue;
			Input = new animQuaternionLink();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
