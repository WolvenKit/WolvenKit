using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PerkHoverOutEvent : redEvent
	{
		private wCHandle<inkWidget> _widget;
		private CHandle<BasePerkDisplayData> _perkData;

		[Ordinal(0)] 
		[RED("widget")] 
		public wCHandle<inkWidget> Widget
		{
			get => GetProperty(ref _widget);
			set => SetProperty(ref _widget, value);
		}

		[Ordinal(1)] 
		[RED("perkData")] 
		public CHandle<BasePerkDisplayData> PerkData
		{
			get => GetProperty(ref _perkData);
			set => SetProperty(ref _perkData, value);
		}

		public PerkHoverOutEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
