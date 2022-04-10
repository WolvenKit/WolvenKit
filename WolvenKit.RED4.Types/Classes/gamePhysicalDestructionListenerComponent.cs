using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamePhysicalDestructionListenerComponent : entIComponent
	{
		[Ordinal(3)] 
		[RED("physicalDestructionComponentName")] 
		public CName PhysicalDestructionComponentName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("thresholdLevels")] 
		public CArray<CFloat> ThresholdLevels
		{
			get => GetPropertyValue<CArray<CFloat>>();
			set => SetPropertyValue<CArray<CFloat>>(value);
		}

		public gamePhysicalDestructionListenerComponent()
		{
			Name = "Component";
			ThresholdLevels = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
