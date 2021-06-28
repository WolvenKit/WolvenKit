using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HubExperienceBarController : inkWidgetLogicController
	{
		private inkWidgetReference _foregroundContainer;

		[Ordinal(1)] 
		[RED("foregroundContainer")] 
		public inkWidgetReference ForegroundContainer
		{
			get => GetProperty(ref _foregroundContainer);
			set => SetProperty(ref _foregroundContainer, value);
		}

		public HubExperienceBarController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
