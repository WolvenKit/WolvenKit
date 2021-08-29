using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class workSequence : workIContainerEntry
	{
		private CBool _previousLoopInfinitely;
		private CBool _loopInfinitely;
		private CEnum<gamedataWorkspotCategory> _category;

		[Ordinal(4)] 
		[RED("previousLoopInfinitely")] 
		public CBool PreviousLoopInfinitely
		{
			get => GetProperty(ref _previousLoopInfinitely);
			set => SetProperty(ref _previousLoopInfinitely, value);
		}

		[Ordinal(5)] 
		[RED("loopInfinitely")] 
		public CBool LoopInfinitely
		{
			get => GetProperty(ref _loopInfinitely);
			set => SetProperty(ref _loopInfinitely, value);
		}

		[Ordinal(6)] 
		[RED("category")] 
		public CEnum<gamedataWorkspotCategory> Category
		{
			get => GetProperty(ref _category);
			set => SetProperty(ref _category, value);
		}
	}
}
