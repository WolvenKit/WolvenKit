using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiInputHintManagerGameController : gameuiWidgetGameController
	{
		private CName _hintContainerId;
		private inkCompoundWidgetReference _baseGroupContainer;
		private inkCompoundWidgetReference _groupsContainer;
		private inkWidgetLibraryReference _hintLibRef;
		private inkWidgetLibraryReference _groupLibRef;
		private CBool _sortInputHints;
		private CBool _useHideOptim;

		[Ordinal(2)] 
		[RED("hintContainerId")] 
		public CName HintContainerId
		{
			get => GetProperty(ref _hintContainerId);
			set => SetProperty(ref _hintContainerId, value);
		}

		[Ordinal(3)] 
		[RED("baseGroupContainer")] 
		public inkCompoundWidgetReference BaseGroupContainer
		{
			get => GetProperty(ref _baseGroupContainer);
			set => SetProperty(ref _baseGroupContainer, value);
		}

		[Ordinal(4)] 
		[RED("groupsContainer")] 
		public inkCompoundWidgetReference GroupsContainer
		{
			get => GetProperty(ref _groupsContainer);
			set => SetProperty(ref _groupsContainer, value);
		}

		[Ordinal(5)] 
		[RED("hintLibRef")] 
		public inkWidgetLibraryReference HintLibRef
		{
			get => GetProperty(ref _hintLibRef);
			set => SetProperty(ref _hintLibRef, value);
		}

		[Ordinal(6)] 
		[RED("groupLibRef")] 
		public inkWidgetLibraryReference GroupLibRef
		{
			get => GetProperty(ref _groupLibRef);
			set => SetProperty(ref _groupLibRef, value);
		}

		[Ordinal(7)] 
		[RED("sortInputHints")] 
		public CBool SortInputHints
		{
			get => GetProperty(ref _sortInputHints);
			set => SetProperty(ref _sortInputHints, value);
		}

		[Ordinal(8)] 
		[RED("useHideOptim")] 
		public CBool UseHideOptim
		{
			get => GetProperty(ref _useHideOptim);
			set => SetProperty(ref _useHideOptim, value);
		}
	}
}
