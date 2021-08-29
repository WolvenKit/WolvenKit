using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CodexListItemController : inkListItemController
	{
		private CBool _doMarkNew;
		private inkWidgetReference _stateMapperRef;
		private CWeakHandle<ListItemStateMapper> _stateMapper;

		[Ordinal(16)] 
		[RED("doMarkNew")] 
		public CBool DoMarkNew
		{
			get => GetProperty(ref _doMarkNew);
			set => SetProperty(ref _doMarkNew, value);
		}

		[Ordinal(17)] 
		[RED("stateMapperRef")] 
		public inkWidgetReference StateMapperRef
		{
			get => GetProperty(ref _stateMapperRef);
			set => SetProperty(ref _stateMapperRef, value);
		}

		[Ordinal(18)] 
		[RED("stateMapper")] 
		public CWeakHandle<ListItemStateMapper> StateMapper
		{
			get => GetProperty(ref _stateMapper);
			set => SetProperty(ref _stateMapper, value);
		}
	}
}
