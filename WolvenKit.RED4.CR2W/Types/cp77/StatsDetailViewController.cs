using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StatsDetailViewController : inkWidgetLogicController
	{
		private inkTextWidgetReference _statLabelRef;
		private inkTextWidgetReference _statValueRef;

		[Ordinal(1)] 
		[RED("StatLabelRef")] 
		public inkTextWidgetReference StatLabelRef
		{
			get => GetProperty(ref _statLabelRef);
			set => SetProperty(ref _statLabelRef, value);
		}

		[Ordinal(2)] 
		[RED("StatValueRef")] 
		public inkTextWidgetReference StatValueRef
		{
			get => GetProperty(ref _statValueRef);
			set => SetProperty(ref _statValueRef, value);
		}

		public StatsDetailViewController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
