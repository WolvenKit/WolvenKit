using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ApplyStatGroupEffector : gameEffector
	{
		[Ordinal(0)] 
		[RED("targets")] 
		public CArray<gameStatsObjectID> Targets
		{
			get => GetPropertyValue<CArray<gameStatsObjectID>>();
			set => SetPropertyValue<CArray<gameStatsObjectID>>(value);
		}

		[Ordinal(1)] 
		[RED("record")] 
		public TweakDBID Record
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(2)] 
		[RED("applicationTarget")] 
		public CName ApplicationTarget
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("targetRequiredTag")] 
		public CName TargetRequiredTag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("modGroupID")] 
		public CUInt64 ModGroupID
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(5)] 
		[RED("stackCount")] 
		public CUInt8 StackCount
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(6)] 
		[RED("removeWithEffector")] 
		public CBool RemoveWithEffector
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("reapplyOnWeaponChange")] 
		public CBool ReapplyOnWeaponChange
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("owner")] 
		public CWeakHandle<gameObject> Owner
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(9)] 
		[RED("ownerSlotCallback")] 
		public CHandle<ApplyStatGroupEffectorCallback> OwnerSlotCallback
		{
			get => GetPropertyValue<CHandle<ApplyStatGroupEffectorCallback>>();
			set => SetPropertyValue<CHandle<ApplyStatGroupEffectorCallback>>(value);
		}

		[Ordinal(10)] 
		[RED("ownerSlotListener")] 
		public CHandle<gameAttachmentSlotsScriptListener> OwnerSlotListener
		{
			get => GetPropertyValue<CHandle<gameAttachmentSlotsScriptListener>>();
			set => SetPropertyValue<CHandle<gameAttachmentSlotsScriptListener>>(value);
		}

		public ApplyStatGroupEffector()
		{
			Targets = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
