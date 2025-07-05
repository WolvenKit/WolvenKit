using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SetBlockShootingFromVehicle : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("enable")] 
		public CBool Enable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public SetBlockShootingFromVehicle()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
