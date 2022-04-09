using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class StillageControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(104)] 
		[RED("isCleared")] 
		public CBool IsCleared
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public StillageControllerPS()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
