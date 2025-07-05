using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entdismembermentAppearanceMatch : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("Character")] 
		public CName Character
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("Mesh")] 
		public CName Mesh
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("SetByUser")] 
		public CBool SetByUser
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public entdismembermentAppearanceMatch()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
