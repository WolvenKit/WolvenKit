using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CyclableRadialSlot : WeaponRadialSlot
	{
		[Ordinal(11)] 
		[RED("leftArrowEmpty")] 
		public inkWidgetReference LeftArrowEmpty
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("leftArrowFull")] 
		public inkWidgetReference LeftArrowFull
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("rightArrowEmpty")] 
		public inkWidgetReference RightArrowEmpty
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("rightArrowFull")] 
		public inkWidgetReference RightArrowFull
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("canCycle")] 
		public CBool CanCycle
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(16)] 
		[RED("isCycling")] 
		public CBool IsCycling
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(17)] 
		[RED("wasCyclingRight")] 
		public CBool WasCyclingRight
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(18)] 
		[RED("hotkey")] 
		public CEnum<gameEHotkey> Hotkey
		{
			get => GetPropertyValue<CEnum<gameEHotkey>>();
			set => SetPropertyValue<CEnum<gameEHotkey>>(value);
		}

		public CyclableRadialSlot()
		{
			LeftArrowEmpty = new inkWidgetReference();
			LeftArrowFull = new inkWidgetReference();
			RightArrowEmpty = new inkWidgetReference();
			RightArrowFull = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
