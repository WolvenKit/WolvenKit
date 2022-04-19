using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_BoolLatch : animAnimNode_BoolValue
	{
		[Ordinal(11)] 
		[RED("input")] 
		public animBoolLink Input
		{
			get => GetPropertyValue<animBoolLink>();
			set => SetPropertyValue<animBoolLink>(value);
		}

		public animAnimNode_BoolLatch()
		{
			Id = 4294967295;
			Input = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
