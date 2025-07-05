using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameWeakspotComponent : entIComponent
	{
		[Ordinal(3)] 
		[RED("defaultPhysicalDestructionProperties")] 
		public gameWeakspotPhysicalDestructionProperties DefaultPhysicalDestructionProperties
		{
			get => GetPropertyValue<gameWeakspotPhysicalDestructionProperties>();
			set => SetPropertyValue<gameWeakspotPhysicalDestructionProperties>(value);
		}

		public gameWeakspotComponent()
		{
			Name = "Component";
			IsReplicable = true;
			DefaultPhysicalDestructionProperties = new gameWeakspotPhysicalDestructionProperties();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
