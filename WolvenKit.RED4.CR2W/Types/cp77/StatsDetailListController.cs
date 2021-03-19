using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StatsDetailListController : inkWidgetLogicController
	{
		private inkTextWidgetReference _statLabelRef;
		private inkCompoundWidgetReference _statsList;

		[Ordinal(1)] 
		[RED("StatLabelRef")] 
		public inkTextWidgetReference StatLabelRef
		{
			get => GetProperty(ref _statLabelRef);
			set => SetProperty(ref _statLabelRef, value);
		}

		[Ordinal(2)] 
		[RED("statsList")] 
		public inkCompoundWidgetReference StatsList
		{
			get => GetProperty(ref _statsList);
			set => SetProperty(ref _statsList, value);
		}

		public StatsDetailListController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
