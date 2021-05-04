using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StatisticDifferenceBarController : inkWidgetLogicController
	{
		private inkWidgetReference _filled;
		private inkWidgetReference _difference;
		private inkWidgetReference _empty;

		[Ordinal(1)] 
		[RED("filled")] 
		public inkWidgetReference Filled
		{
			get => GetProperty(ref _filled);
			set => SetProperty(ref _filled, value);
		}

		[Ordinal(2)] 
		[RED("difference")] 
		public inkWidgetReference Difference
		{
			get => GetProperty(ref _difference);
			set => SetProperty(ref _difference, value);
		}

		[Ordinal(3)] 
		[RED("empty")] 
		public inkWidgetReference Empty
		{
			get => GetProperty(ref _empty);
			set => SetProperty(ref _empty, value);
		}

		public StatisticDifferenceBarController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
