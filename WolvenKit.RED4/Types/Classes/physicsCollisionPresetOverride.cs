using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class physicsCollisionPresetOverride : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("from")] 
		public CName From
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("to")] 
		public CName To
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public physicsCollisionPresetOverride()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
