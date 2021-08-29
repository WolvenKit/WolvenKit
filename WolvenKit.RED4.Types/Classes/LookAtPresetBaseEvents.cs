using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LookAtPresetBaseEvents : DefaultTransition
	{
		private CArray<CHandle<entLookAtAddEvent>> _lookAtEvents;
		private CBool _attachLeft;
		private CBool _attachRight;

		[Ordinal(0)] 
		[RED("lookAtEvents")] 
		public CArray<CHandle<entLookAtAddEvent>> LookAtEvents
		{
			get => GetProperty(ref _lookAtEvents);
			set => SetProperty(ref _lookAtEvents, value);
		}

		[Ordinal(1)] 
		[RED("attachLeft")] 
		public CBool AttachLeft
		{
			get => GetProperty(ref _attachLeft);
			set => SetProperty(ref _attachLeft, value);
		}

		[Ordinal(2)] 
		[RED("attachRight")] 
		public CBool AttachRight
		{
			get => GetProperty(ref _attachRight);
			set => SetProperty(ref _attachRight, value);
		}
	}
}
