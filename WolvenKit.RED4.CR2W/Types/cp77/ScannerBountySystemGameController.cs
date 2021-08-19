using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScannerBountySystemGameController : BaseChunkGameController
	{
		private inkTextWidgetReference _moneyReward;
		private inkWidgetReference _moneyRewardRow;
		private inkTextWidgetReference _streetCredReward;
		private inkWidgetReference _streetCredRewardRow;
		private inkTextWidgetReference _transgressions;
		private inkWidgetReference _transgressionsWidget;
		private inkCompoundWidgetReference _rewardPanel;
		private inkRectangleWidgetReference _mugShot;
		private inkTextWidgetReference _wanted;
		private inkTextWidgetReference _notFound;
		private inkTextWidgetReference _deadNotice;
		private inkWidgetReference _crossedOut;
		private CArray<inkWidgetReference> _starsWidget;
		private CHandle<redCallbackObject> _bountyCallbackID;
		private CHandle<redCallbackObject> _healthCallbackID;
		private CHandle<redCallbackObject> _objectCallbackID;
		private CBool _isValidBounty;
		private CBool _isAlive;
		private CEnum<ScannerObjectType> _objectType;
		private CHandle<inkanimProxy> _showScanBountyAnimProxy;

		[Ordinal(5)] 
		[RED("moneyReward")] 
		public inkTextWidgetReference MoneyReward
		{
			get => GetProperty(ref _moneyReward);
			set => SetProperty(ref _moneyReward, value);
		}

		[Ordinal(6)] 
		[RED("moneyRewardRow")] 
		public inkWidgetReference MoneyRewardRow
		{
			get => GetProperty(ref _moneyRewardRow);
			set => SetProperty(ref _moneyRewardRow, value);
		}

		[Ordinal(7)] 
		[RED("streetCredReward")] 
		public inkTextWidgetReference StreetCredReward
		{
			get => GetProperty(ref _streetCredReward);
			set => SetProperty(ref _streetCredReward, value);
		}

		[Ordinal(8)] 
		[RED("streetCredRewardRow")] 
		public inkWidgetReference StreetCredRewardRow
		{
			get => GetProperty(ref _streetCredRewardRow);
			set => SetProperty(ref _streetCredRewardRow, value);
		}

		[Ordinal(9)] 
		[RED("transgressions")] 
		public inkTextWidgetReference Transgressions
		{
			get => GetProperty(ref _transgressions);
			set => SetProperty(ref _transgressions, value);
		}

		[Ordinal(10)] 
		[RED("transgressionsWidget")] 
		public inkWidgetReference TransgressionsWidget
		{
			get => GetProperty(ref _transgressionsWidget);
			set => SetProperty(ref _transgressionsWidget, value);
		}

		[Ordinal(11)] 
		[RED("rewardPanel")] 
		public inkCompoundWidgetReference RewardPanel
		{
			get => GetProperty(ref _rewardPanel);
			set => SetProperty(ref _rewardPanel, value);
		}

		[Ordinal(12)] 
		[RED("mugShot")] 
		public inkRectangleWidgetReference MugShot
		{
			get => GetProperty(ref _mugShot);
			set => SetProperty(ref _mugShot, value);
		}

		[Ordinal(13)] 
		[RED("wanted")] 
		public inkTextWidgetReference Wanted
		{
			get => GetProperty(ref _wanted);
			set => SetProperty(ref _wanted, value);
		}

		[Ordinal(14)] 
		[RED("notFound")] 
		public inkTextWidgetReference NotFound
		{
			get => GetProperty(ref _notFound);
			set => SetProperty(ref _notFound, value);
		}

		[Ordinal(15)] 
		[RED("deadNotice")] 
		public inkTextWidgetReference DeadNotice
		{
			get => GetProperty(ref _deadNotice);
			set => SetProperty(ref _deadNotice, value);
		}

		[Ordinal(16)] 
		[RED("crossedOut")] 
		public inkWidgetReference CrossedOut
		{
			get => GetProperty(ref _crossedOut);
			set => SetProperty(ref _crossedOut, value);
		}

		[Ordinal(17)] 
		[RED("starsWidget")] 
		public CArray<inkWidgetReference> StarsWidget
		{
			get => GetProperty(ref _starsWidget);
			set => SetProperty(ref _starsWidget, value);
		}

		[Ordinal(18)] 
		[RED("bountyCallbackID")] 
		public CHandle<redCallbackObject> BountyCallbackID
		{
			get => GetProperty(ref _bountyCallbackID);
			set => SetProperty(ref _bountyCallbackID, value);
		}

		[Ordinal(19)] 
		[RED("healthCallbackID")] 
		public CHandle<redCallbackObject> HealthCallbackID
		{
			get => GetProperty(ref _healthCallbackID);
			set => SetProperty(ref _healthCallbackID, value);
		}

		[Ordinal(20)] 
		[RED("objectCallbackID")] 
		public CHandle<redCallbackObject> ObjectCallbackID
		{
			get => GetProperty(ref _objectCallbackID);
			set => SetProperty(ref _objectCallbackID, value);
		}

		[Ordinal(21)] 
		[RED("isValidBounty")] 
		public CBool IsValidBounty
		{
			get => GetProperty(ref _isValidBounty);
			set => SetProperty(ref _isValidBounty, value);
		}

		[Ordinal(22)] 
		[RED("isAlive")] 
		public CBool IsAlive
		{
			get => GetProperty(ref _isAlive);
			set => SetProperty(ref _isAlive, value);
		}

		[Ordinal(23)] 
		[RED("objectType")] 
		public CEnum<ScannerObjectType> ObjectType
		{
			get => GetProperty(ref _objectType);
			set => SetProperty(ref _objectType, value);
		}

		[Ordinal(24)] 
		[RED("showScanBountyAnimProxy")] 
		public CHandle<inkanimProxy> ShowScanBountyAnimProxy
		{
			get => GetProperty(ref _showScanBountyAnimProxy);
			set => SetProperty(ref _showScanBountyAnimProxy, value);
		}

		public ScannerBountySystemGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
