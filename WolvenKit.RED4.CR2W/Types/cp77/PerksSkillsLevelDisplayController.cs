using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PerksSkillsLevelDisplayController : inkWidgetLogicController
	{
		private inkWidgetReference _tint;

		[Ordinal(1)] 
		[RED("tint")] 
		public inkWidgetReference Tint
		{
			get => GetProperty(ref _tint);
			set => SetProperty(ref _tint, value);
		}

		public PerksSkillsLevelDisplayController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
