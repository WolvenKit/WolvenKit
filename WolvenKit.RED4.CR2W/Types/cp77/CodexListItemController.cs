using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CodexListItemController : inkListItemController
	{
		private CBool _doMarkNew;
		private inkWidgetReference _stateMapperRef;
		private wCHandle<ListItemStateMapper> _stateMapper;

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
		public wCHandle<ListItemStateMapper> StateMapper
		{
			get => GetProperty(ref _stateMapper);
			set => SetProperty(ref _stateMapper, value);
		}

		public CodexListItemController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
