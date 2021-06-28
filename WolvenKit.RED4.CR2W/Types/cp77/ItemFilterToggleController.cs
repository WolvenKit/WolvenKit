using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemFilterToggleController : ToggleController
	{
		private inkWidgetReference _newItemDot;
		private CBool _useCategoryFilter;

		[Ordinal(16)] 
		[RED("newItemDot")] 
		public inkWidgetReference NewItemDot
		{
			get => GetProperty(ref _newItemDot);
			set => SetProperty(ref _newItemDot, value);
		}

		[Ordinal(17)] 
		[RED("useCategoryFilter")] 
		public CBool UseCategoryFilter
		{
			get => GetProperty(ref _useCategoryFilter);
			set => SetProperty(ref _useCategoryFilter, value);
		}

		public ItemFilterToggleController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
