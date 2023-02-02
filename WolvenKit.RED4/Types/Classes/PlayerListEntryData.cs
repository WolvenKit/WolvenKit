using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PlayerListEntryData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("playerObject")] 
		public CWeakHandle<gameObject> PlayerObject
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(1)] 
		[RED("playerListEntry")] 
		public CWeakHandle<inkWidget> PlayerListEntry
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		public PlayerListEntryData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
