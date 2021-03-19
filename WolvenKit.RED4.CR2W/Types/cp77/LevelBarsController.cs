using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LevelBarsController : inkWidgetLogicController
	{
		private inkWidgetReference _bar0;
		private inkWidgetReference _bar1;
		private inkWidgetReference _bar2;
		private inkWidgetReference _bar3;
		private inkWidgetReference _bar4;
		private CArrayFixedSize<inkWidgetReference> _bars;

		[Ordinal(1)] 
		[RED("bar0")] 
		public inkWidgetReference Bar0
		{
			get => GetProperty(ref _bar0);
			set => SetProperty(ref _bar0, value);
		}

		[Ordinal(2)] 
		[RED("bar1")] 
		public inkWidgetReference Bar1
		{
			get => GetProperty(ref _bar1);
			set => SetProperty(ref _bar1, value);
		}

		[Ordinal(3)] 
		[RED("bar2")] 
		public inkWidgetReference Bar2
		{
			get => GetProperty(ref _bar2);
			set => SetProperty(ref _bar2, value);
		}

		[Ordinal(4)] 
		[RED("bar3")] 
		public inkWidgetReference Bar3
		{
			get => GetProperty(ref _bar3);
			set => SetProperty(ref _bar3, value);
		}

		[Ordinal(5)] 
		[RED("bar4")] 
		public inkWidgetReference Bar4
		{
			get => GetProperty(ref _bar4);
			set => SetProperty(ref _bar4, value);
		}

		[Ordinal(6)] 
		[RED("bars", 5)] 
		public CArrayFixedSize<inkWidgetReference> Bars
		{
			get => GetProperty(ref _bars);
			set => SetProperty(ref _bars, value);
		}

		public LevelBarsController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
