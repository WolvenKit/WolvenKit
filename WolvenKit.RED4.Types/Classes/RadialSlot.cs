using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RadialSlot : IScriptable
	{
		private inkWidgetReference _slotAnchorRef;
		private inkWidgetLibraryReference _libraryRef;
		private CEnum<SlotType> _slotType;
		private RadialAnimData _animData;
		private CWeakHandle<inkWidget> _widget;
		private CFloat _targetAngle;
		private CString _active;
		private CString _inactive;
		private CString _blocked;

		[Ordinal(0)] 
		[RED("slotAnchorRef")] 
		public inkWidgetReference SlotAnchorRef
		{
			get => GetProperty(ref _slotAnchorRef);
			set => SetProperty(ref _slotAnchorRef, value);
		}

		[Ordinal(1)] 
		[RED("libraryRef")] 
		public inkWidgetLibraryReference LibraryRef
		{
			get => GetProperty(ref _libraryRef);
			set => SetProperty(ref _libraryRef, value);
		}

		[Ordinal(2)] 
		[RED("slotType")] 
		public CEnum<SlotType> SlotType
		{
			get => GetProperty(ref _slotType);
			set => SetProperty(ref _slotType, value);
		}

		[Ordinal(3)] 
		[RED("animData")] 
		public RadialAnimData AnimData
		{
			get => GetProperty(ref _animData);
			set => SetProperty(ref _animData, value);
		}

		[Ordinal(4)] 
		[RED("widget")] 
		public CWeakHandle<inkWidget> Widget
		{
			get => GetProperty(ref _widget);
			set => SetProperty(ref _widget, value);
		}

		[Ordinal(5)] 
		[RED("targetAngle")] 
		public CFloat TargetAngle
		{
			get => GetProperty(ref _targetAngle);
			set => SetProperty(ref _targetAngle, value);
		}

		[Ordinal(6)] 
		[RED("active")] 
		public CString Active
		{
			get => GetProperty(ref _active);
			set => SetProperty(ref _active, value);
		}

		[Ordinal(7)] 
		[RED("inactive")] 
		public CString Inactive
		{
			get => GetProperty(ref _inactive);
			set => SetProperty(ref _inactive, value);
		}

		[Ordinal(8)] 
		[RED("blocked")] 
		public CString Blocked
		{
			get => GetProperty(ref _blocked);
			set => SetProperty(ref _blocked, value);
		}
	}
}
