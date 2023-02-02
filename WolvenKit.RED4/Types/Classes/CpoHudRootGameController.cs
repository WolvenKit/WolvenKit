using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CpoHudRootGameController : gameuiWidgetGameController
	{
		[Ordinal(2)] 
		[RED("hitIndicator")] 
		public CWeakHandle<inkWidget> HitIndicator
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(3)] 
		[RED("chatBox")] 
		public CWeakHandle<inkWidget> ChatBox
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(4)] 
		[RED("playerList")] 
		public CWeakHandle<inkWidget> PlayerList
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(5)] 
		[RED("narration_journal")] 
		public CWeakHandle<inkWidget> Narration_journal
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(6)] 
		[RED("narrative_plate")] 
		public CWeakHandle<inkWidget> Narrative_plate
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(7)] 
		[RED("inventory")] 
		public CWeakHandle<inkWidget> Inventory
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(8)] 
		[RED("loadouts")] 
		public CWeakHandle<inkWidget> Loadouts
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		public CpoHudRootGameController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
