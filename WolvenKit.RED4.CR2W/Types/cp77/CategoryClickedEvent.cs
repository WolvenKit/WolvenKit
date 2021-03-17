using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CategoryClickedEvent : redEvent
	{
		private gameStatViewData _statsData;

		[Ordinal(0)] 
		[RED("statsData")] 
		public gameStatViewData StatsData
		{
			get => GetProperty(ref _statsData);
			set => SetProperty(ref _statsData, value);
		}

		public CategoryClickedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
