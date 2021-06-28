using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StatsPlayTimeController : inkWidgetLogicController
	{
		private inkTextWidgetReference _playTimeRef;
		private inkTextWidgetReference _lifePathRef;
		private inkImageWidgetReference _lifePathIconRef;

		[Ordinal(1)] 
		[RED("playTimeRef")] 
		public inkTextWidgetReference PlayTimeRef
		{
			get => GetProperty(ref _playTimeRef);
			set => SetProperty(ref _playTimeRef, value);
		}

		[Ordinal(2)] 
		[RED("lifePathRef")] 
		public inkTextWidgetReference LifePathRef
		{
			get => GetProperty(ref _lifePathRef);
			set => SetProperty(ref _lifePathRef, value);
		}

		[Ordinal(3)] 
		[RED("lifePathIconRef")] 
		public inkImageWidgetReference LifePathIconRef
		{
			get => GetProperty(ref _lifePathIconRef);
			set => SetProperty(ref _lifePathIconRef, value);
		}

		public StatsPlayTimeController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
