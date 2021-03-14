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
			get
			{
				if (_prevRewardsList == null)
				{
					_prevRewardsList = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "prevRewardsList", cr2w, this);
				}
				return _prevRewardsList;
			}
			set
			{
				if (_prevRewardsList == value)
				{
					return;
				}
				_prevRewardsList = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("currentRewardsList")] 
		public inkCompoundWidgetReference CurrentRewardsList
		{
			get
			{
				if (_currentRewardsList == null)
				{
					_currentRewardsList = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "currentRewardsList", cr2w, this);
				}
				return _currentRewardsList;
			}
			set
			{
				if (_currentRewardsList == value)
				{
					return;
				}
				_currentRewardsList = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("nextRewardsList")] 
		public inkCompoundWidgetReference NextRewardsList
		{
			get
			{
				if (_nextRewardsList == null)
				{
					_nextRewardsList = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "nextRewardsList", cr2w, this);
				}
				return _nextRewardsList;
			}
			set
			{
				if (_nextRewardsList == value)
				{
					return;
				}
				_nextRewardsList = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("scrollSlider")] 
		public inkCompoundWidgetReference ScrollSlider
		{
			get
			{
				if (_scrollSlider == null)
				{
					_scrollSlider = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "scrollSlider", cr2w, this);
				}
				return _scrollSlider;
			}
			set
			{
				if (_scrollSlider == value)
				{
					return;
				}
				_scrollSlider = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("scrollButtonHint")] 
		public inkCompoundWidgetReference ScrollButtonHint
		{
			get
			{
				if (_scrollButtonHint == null)
				{
					_scrollButtonHint = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "scrollButtonHint", cr2w, this);
				}
				return _scrollButtonHint;
			}
			set
			{
				if (_scrollButtonHint == value)
				{
					return;
				}
				_scrollButtonHint = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("rewardSize")] 
		public CInt32 RewardSize
		{
			get
			{
				if (_rewardSize == null)
				{
					_rewardSize = (CInt32) CR2WTypeManager.Create("Int32", "rewardSize", cr2w, this);
				}
				return _rewardSize;
			}
			set
			{
				if (_rewardSize == value)
				{
					return;
				}
				_rewardSize = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("tooltipIndex")] 
		public CInt32 TooltipIndex
		{
			get
			{
				if (_tooltipIndex == null)
				{
					_tooltipIndex = (CInt32) CR2WTypeManager.Create("Int32", "tooltipIndex", cr2w, this);
				}
				return _tooltipIndex;
			}
			set
			{
				if (_tooltipIndex == value)
				{
					return;
				}
				_tooltipIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("tooltipsManager")] 
		public wCHandle<gameuiTooltipsManager> TooltipsManager
		{
			get
			{
				if (_tooltipsManager == null)
				{
					_tooltipsManager = (wCHandle<gameuiTooltipsManager>) CR2WTypeManager.Create("whandle:gameuiTooltipsManager", "tooltipsManager", cr2w, this);
				}
				return _tooltipsManager;
			}
			set
			{
				if (_tooltipsManager == value)
				{
					return;
				}
				_tooltipsManager = value;
				PropertySet(this);
			}
		}

		public StatsStreetCredReward(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
