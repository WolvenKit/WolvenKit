using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemRandomizedStatsController : inkWidgetLogicController
	{
		private inkTextWidgetReference _statName;

		[Ordinal(1)] 
		[RED("statName")] 
		public inkTextWidgetReference StatName
		{
			get => GetProperty(ref _statName);
			set => SetProperty(ref _statName, value);
		}

		public ItemRandomizedStatsController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
