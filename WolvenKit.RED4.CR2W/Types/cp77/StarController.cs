using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StarController : inkWidgetLogicController
	{
		private inkWidgetReference _bountyBadgeWidget;

		[Ordinal(1)] 
		[RED("bountyBadgeWidget")] 
		public inkWidgetReference BountyBadgeWidget
		{
			get => GetProperty(ref _bountyBadgeWidget);
			set => SetProperty(ref _bountyBadgeWidget, value);
		}

		public StarController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
