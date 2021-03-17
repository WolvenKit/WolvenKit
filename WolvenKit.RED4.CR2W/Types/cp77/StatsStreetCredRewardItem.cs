using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StatsStreetCredRewardItem : inkButtonController
	{
		private inkTextWidgetReference _levelRef;
		private inkImageWidgetReference _iconRef;
		private CHandle<LevelRewardDisplayData> _data;

		[Ordinal(10)] 
		[RED("levelRef")] 
		public inkTextWidgetReference LevelRef
		{
			get => GetProperty(ref _levelRef);
			set => SetProperty(ref _levelRef, value);
		}

		[Ordinal(11)] 
		[RED("iconRef")] 
		public inkImageWidgetReference IconRef
		{
			get => GetProperty(ref _iconRef);
			set => SetProperty(ref _iconRef, value);
		}

		[Ordinal(12)] 
		[RED("data")] 
		public CHandle<LevelRewardDisplayData> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		public StatsStreetCredRewardItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
