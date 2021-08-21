using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CraftingSkillWidget : gameuiWidgetGameController
	{
		private inkTextWidgetReference _amountText;
		private inkWidgetReference _expFill;
		private inkWidgetReference _perkHolder;
		private inkWidgetReference _levelUpAnimation;
		private inkWidgetReference _expAnimation;
		private inkTextWidgetReference _nextLevelText;
		private inkTextWidgetReference _expPointText1;
		private inkTextWidgetReference _expPointText2;
		private wCHandle<gameIBlackboard> _levelUpBlackboard;
		private CHandle<redCallbackObject> _playerLevelUpListener;
		private CBool _isLevelUp;
		private CInt32 _currentExp;

		[Ordinal(2)] 
		[RED("amountText")] 
		public inkTextWidgetReference AmountText
		{
			get => GetProperty(ref _amountText);
			set => SetProperty(ref _amountText, value);
		}

		[Ordinal(3)] 
		[RED("expFill")] 
		public inkWidgetReference ExpFill
		{
			get => GetProperty(ref _expFill);
			set => SetProperty(ref _expFill, value);
		}

		[Ordinal(4)] 
		[RED("perkHolder")] 
		public inkWidgetReference PerkHolder
		{
			get => GetProperty(ref _perkHolder);
			set => SetProperty(ref _perkHolder, value);
		}

		[Ordinal(5)] 
		[RED("levelUpAnimation")] 
		public inkWidgetReference LevelUpAnimation
		{
			get => GetProperty(ref _levelUpAnimation);
			set => SetProperty(ref _levelUpAnimation, value);
		}

		[Ordinal(6)] 
		[RED("expAnimation")] 
		public inkWidgetReference ExpAnimation
		{
			get => GetProperty(ref _expAnimation);
			set => SetProperty(ref _expAnimation, value);
		}

		[Ordinal(7)] 
		[RED("nextLevelText")] 
		public inkTextWidgetReference NextLevelText
		{
			get => GetProperty(ref _nextLevelText);
			set => SetProperty(ref _nextLevelText, value);
		}

		[Ordinal(8)] 
		[RED("expPointText1")] 
		public inkTextWidgetReference ExpPointText1
		{
			get => GetProperty(ref _expPointText1);
			set => SetProperty(ref _expPointText1, value);
		}

		[Ordinal(9)] 
		[RED("expPointText2")] 
		public inkTextWidgetReference ExpPointText2
		{
			get => GetProperty(ref _expPointText2);
			set => SetProperty(ref _expPointText2, value);
		}

		[Ordinal(10)] 
		[RED("levelUpBlackboard")] 
		public wCHandle<gameIBlackboard> LevelUpBlackboard
		{
			get => GetProperty(ref _levelUpBlackboard);
			set => SetProperty(ref _levelUpBlackboard, value);
		}

		[Ordinal(11)] 
		[RED("playerLevelUpListener")] 
		public CHandle<redCallbackObject> PlayerLevelUpListener
		{
			get => GetProperty(ref _playerLevelUpListener);
			set => SetProperty(ref _playerLevelUpListener, value);
		}

		[Ordinal(12)] 
		[RED("isLevelUp")] 
		public CBool IsLevelUp
		{
			get => GetProperty(ref _isLevelUp);
			set => SetProperty(ref _isLevelUp, value);
		}

		[Ordinal(13)] 
		[RED("currentExp")] 
		public CInt32 CurrentExp
		{
			get => GetProperty(ref _currentExp);
			set => SetProperty(ref _currentExp, value);
		}

		public CraftingSkillWidget(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
