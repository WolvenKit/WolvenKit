using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ModifyOverlappedSecurityAreas : redEvent
	{
		[Ordinal(0)] 
		[RED("isEntering")] 
		public CBool IsEntering
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("zoneID")] 
		public gamePersistentID ZoneID
		{
			get => GetPropertyValue<gamePersistentID>();
			set => SetPropertyValue<gamePersistentID>(value);
		}

		public ModifyOverlappedSecurityAreas()
		{
			ZoneID = new gamePersistentID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
