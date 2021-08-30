using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnCinematicAnimSetSRRef : RedBaseClass
	{
		private CResourceAsyncReference<animAnimSet> _asyncAnimSet;
		private CUInt8 _priority;
		private CBool _isOverride;

		[Ordinal(0)] 
		[RED("asyncAnimSet")] 
		public CResourceAsyncReference<animAnimSet> AsyncAnimSet
		{
			get => GetProperty(ref _asyncAnimSet);
			set => SetProperty(ref _asyncAnimSet, value);
		}

		[Ordinal(1)] 
		[RED("priority")] 
		public CUInt8 Priority
		{
			get => GetProperty(ref _priority);
			set => SetProperty(ref _priority, value);
		}

		[Ordinal(2)] 
		[RED("isOverride")] 
		public CBool IsOverride
		{
			get => GetProperty(ref _isOverride);
			set => SetProperty(ref _isOverride, value);
		}

		public scnCinematicAnimSetSRRef()
		{
			_priority = 128;
		}
	}
}
