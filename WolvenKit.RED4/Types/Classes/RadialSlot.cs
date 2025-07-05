using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RadialSlot : IScriptable
	{
		[Ordinal(0)] 
		[RED("slotAnchorRef")] 
		public inkWidgetReference SlotAnchorRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(1)] 
		[RED("libraryRef")] 
		public inkWidgetLibraryReference LibraryRef
		{
			get => GetPropertyValue<inkWidgetLibraryReference>();
			set => SetPropertyValue<inkWidgetLibraryReference>(value);
		}

		[Ordinal(2)] 
		[RED("slotType")] 
		public CEnum<SlotType> SlotType
		{
			get => GetPropertyValue<CEnum<SlotType>>();
			set => SetPropertyValue<CEnum<SlotType>>(value);
		}

		[Ordinal(3)] 
		[RED("animData")] 
		public RadialAnimData AnimData
		{
			get => GetPropertyValue<RadialAnimData>();
			set => SetPropertyValue<RadialAnimData>(value);
		}

		[Ordinal(4)] 
		[RED("widget")] 
		public CWeakHandle<inkWidget> Widget
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(5)] 
		[RED("targetAngle")] 
		public CFloat TargetAngle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("active")] 
		public CString Active
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(7)] 
		[RED("inactive")] 
		public CString Inactive
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(8)] 
		[RED("blocked")] 
		public CString Blocked
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public RadialSlot()
		{
			SlotAnchorRef = new inkWidgetReference();
			LibraryRef = new inkWidgetLibraryReference { WidgetLibrary = new inkWidgetLibraryResourceWrapper() };
			AnimData = new RadialAnimData { Hover_in = "Anim name for hover in", Hover_out = "Anim name for hover out", Cycle_in = "Anim name for cycle in animation", Cycle_out = "Anim name for cycle out animation" };
			Active = "Hover";
			Inactive = "Default";
			Blocked = "Blocked";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
