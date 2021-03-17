using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class lookAtPresetGunBaseEvents : LookAtPresetBaseEvents
	{
		private CArray<CHandle<entLookAtAddEvent>> _overrideLookAtEvents;
		private CInt32 _gunState;
		private CBool _originalAttachLeft;
		private CBool _originalAttachRight;

		[Ordinal(3)] 
		[RED("overrideLookAtEvents")] 
		public CArray<CHandle<entLookAtAddEvent>> OverrideLookAtEvents
		{
			get => GetProperty(ref _overrideLookAtEvents);
			set => SetProperty(ref _overrideLookAtEvents, value);
		}

		[Ordinal(4)] 
		[RED("gunState")] 
		public CInt32 GunState
		{
			get => GetProperty(ref _gunState);
			set => SetProperty(ref _gunState, value);
		}

		[Ordinal(5)] 
		[RED("originalAttachLeft")] 
		public CBool OriginalAttachLeft
		{
			get => GetProperty(ref _originalAttachLeft);
			set => SetProperty(ref _originalAttachLeft, value);
		}

		[Ordinal(6)] 
		[RED("originalAttachRight")] 
		public CBool OriginalAttachRight
		{
			get => GetProperty(ref _originalAttachRight);
			set => SetProperty(ref _originalAttachRight, value);
		}

		public lookAtPresetGunBaseEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
