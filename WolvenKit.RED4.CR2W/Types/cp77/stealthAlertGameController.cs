using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class stealthAlertGameController : gameuiHUDGameController
	{
		private inkTextWidgetReference _label;
		private inkImageWidgetReference _icon;
		private inkImageWidgetReference _indicator_01;
		private inkImageWidgetReference _indicator_02;
		private inkImageWidgetReference _indicator_03;
		private inkWidgetReference _fluff_01;
		private inkWidgetReference _fluff_02;
		private inkWidgetReference _fluff_03;
		private inkWidgetReference _fluff_04;
		private wCHandle<inkWidget> _root;
		private CUInt32 _securityBlackBoardID;
		private CUInt32 _playerBlackboardID;
		private CHandle<gameIBlackboard> _blackboard;
		private wCHandle<gameObject> _playerPuppet;
		private CHandle<inkanimProxy> _animationProxy;

		[Ordinal(9)] 
		[RED("label")] 
		public inkTextWidgetReference Label
		{
			get => GetProperty(ref _label);
			set => SetProperty(ref _label, value);
		}

		[Ordinal(10)] 
		[RED("icon")] 
		public inkImageWidgetReference Icon
		{
			get => GetProperty(ref _icon);
			set => SetProperty(ref _icon, value);
		}

		[Ordinal(11)] 
		[RED("indicator_01")] 
		public inkImageWidgetReference Indicator_01
		{
			get => GetProperty(ref _indicator_01);
			set => SetProperty(ref _indicator_01, value);
		}

		[Ordinal(12)] 
		[RED("indicator_02")] 
		public inkImageWidgetReference Indicator_02
		{
			get => GetProperty(ref _indicator_02);
			set => SetProperty(ref _indicator_02, value);
		}

		[Ordinal(13)] 
		[RED("indicator_03")] 
		public inkImageWidgetReference Indicator_03
		{
			get => GetProperty(ref _indicator_03);
			set => SetProperty(ref _indicator_03, value);
		}

		[Ordinal(14)] 
		[RED("fluff_01")] 
		public inkWidgetReference Fluff_01
		{
			get => GetProperty(ref _fluff_01);
			set => SetProperty(ref _fluff_01, value);
		}

		[Ordinal(15)] 
		[RED("fluff_02")] 
		public inkWidgetReference Fluff_02
		{
			get => GetProperty(ref _fluff_02);
			set => SetProperty(ref _fluff_02, value);
		}

		[Ordinal(16)] 
		[RED("fluff_03")] 
		public inkWidgetReference Fluff_03
		{
			get => GetProperty(ref _fluff_03);
			set => SetProperty(ref _fluff_03, value);
		}

		[Ordinal(17)] 
		[RED("fluff_04")] 
		public inkWidgetReference Fluff_04
		{
			get => GetProperty(ref _fluff_04);
			set => SetProperty(ref _fluff_04, value);
		}

		[Ordinal(18)] 
		[RED("root")] 
		public wCHandle<inkWidget> Root
		{
			get => GetProperty(ref _root);
			set => SetProperty(ref _root, value);
		}

		[Ordinal(19)] 
		[RED("securityBlackBoardID")] 
		public CUInt32 SecurityBlackBoardID
		{
			get => GetProperty(ref _securityBlackBoardID);
			set => SetProperty(ref _securityBlackBoardID, value);
		}

		[Ordinal(20)] 
		[RED("playerBlackboardID")] 
		public CUInt32 PlayerBlackboardID
		{
			get => GetProperty(ref _playerBlackboardID);
			set => SetProperty(ref _playerBlackboardID, value);
		}

		[Ordinal(21)] 
		[RED("blackboard")] 
		public CHandle<gameIBlackboard> Blackboard
		{
			get => GetProperty(ref _blackboard);
			set => SetProperty(ref _blackboard, value);
		}

		[Ordinal(22)] 
		[RED("playerPuppet")] 
		public wCHandle<gameObject> PlayerPuppet
		{
			get => GetProperty(ref _playerPuppet);
			set => SetProperty(ref _playerPuppet, value);
		}

		[Ordinal(23)] 
		[RED("animationProxy")] 
		public CHandle<inkanimProxy> AnimationProxy
		{
			get => GetProperty(ref _animationProxy);
			set => SetProperty(ref _animationProxy, value);
		}

		public stealthAlertGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
