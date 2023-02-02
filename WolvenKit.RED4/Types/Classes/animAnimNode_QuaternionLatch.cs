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
			Id = 4294967295;
			Input = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
