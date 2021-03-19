using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StatsStreetCredReward : inkWidgetLogicController
	{
		private inkCompoundWidgetReference _prevRewardsList;
		private inkCompoundWidgetReference _currentRewardsList;
		private inkCompoundWidgetReference _nextRewardsList;
		private inkCompoundWidgetReference _scrollSlider;
		private inkCompoundWidgetReference _scrollButtonHint;
		private CInt32 _rewardSize;
		private CInt32 _tooltipIndex;
		private wCHandle<gameuiTooltipsManager> _tooltipsManager;

		[Ordinal(1)] 
		[RED("prevRewardsList")] 
		public inkCompoundWidgetReference PrevRewardsList
		{
			get => GetProperty(ref _prevRewardsList);
			set => SetProperty(ref _prevRewardsList, value);
		}

		[Ordinal(2)] 
		[RED("currentRewardsList")] 
		public inkCompoundWidgetReference CurrentRewardsList
		{
			get => GetProperty(ref _currentRewardsList);
			set => SetProperty(ref _currentRewardsList, value);
		}

		[Ordinal(3)] 
		[RED("nextRewardsList")] 
		public inkCompoundWidgetReference NextRewardsList
		{
			get => GetProperty(ref _nextRewardsList);
			set => SetProperty(ref _nextRewardsList, value);
		}

		[Ordinal(4)] 
		[RED("scrollSlider")] 
		public inkCompoundWidgetReference ScrollSlider
		{
			get => GetProperty(ref _scrollSlider);
			set => SetProperty(ref _scrollSlider, value);
		}

		[Ordinal(5)] 
		[RED("scrollButtonHint")] 
		public inkCompoundWidgetReference ScrollButtonHint
		{
			get => GetProperty(ref _scrollButtonHint);
			set => SetProperty(ref _scrollButtonHint, value);
		}

		[Ordinal(6)] 
		[RED("rewardSize")] 
		public CInt32 RewardSize
		{
			get => GetProperty(ref _rewardSize);
			set => SetProperty(ref _rewardSize, value);
		}

		[Ordinal(7)] 
		[RED("tooltipIndex")] 
		public CInt32 TooltipIndex
		{
			get => GetProperty(ref _tooltipIndex);
			set => SetProperty(ref _tooltipIndex, value);
		}

		[Ordinal(8)] 
		[RED("tooltipsManager")] 
		public wCHandle<gameuiTooltipsManager> TooltipsManager
		{
			get => GetProperty(ref _tooltipsManager);
			set => SetProperty(ref _tooltipsManager, value);
		}

		public StatsStreetCredReward(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
