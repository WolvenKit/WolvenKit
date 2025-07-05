using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class KiroshiHighlightEffector : HighlightEffector
	{
		[Ordinal(6)] 
		[RED("onlyWhileAiming")] 
		public CBool OnlyWhileAiming
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("onlyClosestToCrosshair")] 
		public CBool OnlyClosestToCrosshair
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("onlyClosestByDistance")] 
		public CBool OnlyClosestByDistance
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("aimingStatListener")] 
		public CHandle<KiroshiEffectorIsAimingStatListener> AimingStatListener
		{
			get => GetPropertyValue<CHandle<KiroshiEffectorIsAimingStatListener>>();
			set => SetPropertyValue<CHandle<KiroshiEffectorIsAimingStatListener>>(value);
		}

		[Ordinal(10)] 
		[RED("techPreviewStatListener")] 
		public CHandle<KiroshiEffectorTechPreviewStatListener> TechPreviewStatListener
		{
			get => GetPropertyValue<CHandle<KiroshiEffectorTechPreviewStatListener>>();
			set => SetPropertyValue<CHandle<KiroshiEffectorTechPreviewStatListener>>(value);
		}

		[Ordinal(11)] 
		[RED("slotCallback")] 
		public CHandle<KiroshiHighlightEffectorCallback> SlotCallback
		{
			get => GetPropertyValue<CHandle<KiroshiHighlightEffectorCallback>>();
			set => SetPropertyValue<CHandle<KiroshiHighlightEffectorCallback>>(value);
		}

		[Ordinal(12)] 
		[RED("slotListener")] 
		public CHandle<gameAttachmentSlotsScriptListener> SlotListener
		{
			get => GetPropertyValue<CHandle<gameAttachmentSlotsScriptListener>>();
			set => SetPropertyValue<CHandle<gameAttachmentSlotsScriptListener>>(value);
		}

		[Ordinal(13)] 
		[RED("IsAiming")] 
		public CBool IsAiming
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(14)] 
		[RED("isTechWeaponEquipped")] 
		public CBool IsTechWeaponEquipped
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(15)] 
		[RED("isMeleeWeaponEquipped")] 
		public CBool IsMeleeWeaponEquipped
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(16)] 
		[RED("isTechPreviewEnabled")] 
		public CBool IsTechPreviewEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public KiroshiHighlightEffector()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
