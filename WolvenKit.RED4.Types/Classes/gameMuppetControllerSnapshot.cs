using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameMuppetControllerSnapshot : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("controllerId")] 
		public CName ControllerId
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("isActive")] 
		public CBool IsActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameMuppetControllerSnapshot()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
