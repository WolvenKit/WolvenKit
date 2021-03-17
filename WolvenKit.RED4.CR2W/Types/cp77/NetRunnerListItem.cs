using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NetRunnerListItem : inkWidgetLogicController
	{
		private inkWidgetReference _highlight;

		[Ordinal(1)] 
		[RED("highlight")] 
		public inkWidgetReference Highlight
		{
			get => GetProperty(ref _highlight);
			set => SetProperty(ref _highlight, value);
		}

		public NetRunnerListItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
