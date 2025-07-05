using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SetPoliceForcesPool : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("disableOnFootSpawn")] 
		public CBool DisableOnFootSpawn
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("disableVehicleSpawn")] 
		public CBool DisableVehicleSpawn
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("disableDroneSpawn")] 
		public CBool DisableDroneSpawn
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("resetToDefault")] 
		public CBool ResetToDefault
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("source")] 
		public CName Source
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public SetPoliceForcesPool()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
