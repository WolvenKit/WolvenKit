using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameWeakspotPhysicalDestructionProperties : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("velocity")] 
		public CFloat Velocity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameWeakspotPhysicalDestructionProperties()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
