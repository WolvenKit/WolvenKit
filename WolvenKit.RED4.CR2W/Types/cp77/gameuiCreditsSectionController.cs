using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiCreditsSectionController : inkWidgetLogicController
	{
		private inkTextWidgetReference _sectionName;

		[Ordinal(1)] 
		[RED("sectionName")] 
		public inkTextWidgetReference SectionName
		{
			get => GetProperty(ref _sectionName);
			set => SetProperty(ref _sectionName, value);
		}

		public gameuiCreditsSectionController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
