using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameWeakspotPhysicalDestructionComponent : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("componentName")] 
		public CName ComponentName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("useDefaultOwnerProperties")] 
		public CBool UseDefaultOwnerProperties
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("destructionProperties")] 
		public gameWeakspotPhysicalDestructionProperties DestructionProperties
		{
			get => GetPropertyValue<gameWeakspotPhysicalDestructionProperties>();
			set => SetPropertyValue<gameWeakspotPhysicalDestructionProperties>(value);
		}

		public gameWeakspotPhysicalDestructionComponent()
		{
			UseDefaultOwnerProperties = true;
			DestructionProperties = new gameWeakspotPhysicalDestructionProperties();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
