using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PocketRadio : IScriptable
	{
		[Ordinal(0)] 
		[RED("player")] 
		public CWeakHandle<PlayerPuppet> Player
		{
			get => GetPropertyValue<CWeakHandle<PlayerPuppet>>();
			set => SetPropertyValue<CWeakHandle<PlayerPuppet>>(value);
		}

		[Ordinal(1)] 
		[RED("station")] 
		public CInt32 Station
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(2)] 
		[RED("selectedStation")] 
		public CInt32 SelectedStation
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(3)] 
		[RED("toggledStation")] 
		public CInt32 ToggledStation
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(4)] 
		[RED("restrictions")] 
		public CArray<CBool> Restrictions
		{
			get => GetPropertyValue<CArray<CBool>>();
			set => SetPropertyValue<CArray<CBool>>(value);
		}

		[Ordinal(5)] 
		[RED("isConditionRestricted")] 
		public CBool IsConditionRestricted
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("isUnlockDelayRestricted")] 
		public CBool IsUnlockDelayRestricted
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("isRestrictionOverwritten")] 
		public CBool IsRestrictionOverwritten
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("isOn")] 
		public CBool IsOn
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("questContentLockListener")] 
		public CHandle<PocketRadioQuestContentLockListener> QuestContentLockListener
		{
			get => GetPropertyValue<CHandle<PocketRadioQuestContentLockListener>>();
			set => SetPropertyValue<CHandle<PocketRadioQuestContentLockListener>>(value);
		}

		[Ordinal(10)] 
		[RED("radioPressTime")] 
		public CFloat RadioPressTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(11)] 
		[RED("isInMetro")] 
		public CBool IsInMetro
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public PocketRadio()
		{
			Restrictions = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
