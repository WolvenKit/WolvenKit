using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiQuadRacerPlayer : gameuiSideScrollerMiniGamePlayerController
	{
		private inkImageWidgetReference _playerImage;
		private inkImageWidgetReference _leftTireSmoke;
		private inkImageWidgetReference _rightTireSmoke;
		private inkImageWidgetReference _rightFlame;
		private inkImageWidgetReference _leftFlame;
		private CName _leftTurnAtlasRegion;
		private CName _rightTurnAtlasRegion;
		private CName _straightTurnAtlasRegion;

		[Ordinal(1)] 
		[RED("playerImage")] 
		public inkImageWidgetReference PlayerImage
		{
			get => GetProperty(ref _playerImage);
			set => SetProperty(ref _playerImage, value);
		}

		[Ordinal(2)] 
		[RED("leftTireSmoke")] 
		public inkImageWidgetReference LeftTireSmoke
		{
			get => GetProperty(ref _leftTireSmoke);
			set => SetProperty(ref _leftTireSmoke, value);
		}

		[Ordinal(3)] 
		[RED("rightTireSmoke")] 
		public inkImageWidgetReference RightTireSmoke
		{
			get => GetProperty(ref _rightTireSmoke);
			set => SetProperty(ref _rightTireSmoke, value);
		}

		[Ordinal(4)] 
		[RED("rightFlame")] 
		public inkImageWidgetReference RightFlame
		{
			get => GetProperty(ref _rightFlame);
			set => SetProperty(ref _rightFlame, value);
		}

		[Ordinal(5)] 
		[RED("leftFlame")] 
		public inkImageWidgetReference LeftFlame
		{
			get => GetProperty(ref _leftFlame);
			set => SetProperty(ref _leftFlame, value);
		}

		[Ordinal(6)] 
		[RED("leftTurnAtlasRegion")] 
		public CName LeftTurnAtlasRegion
		{
			get => GetProperty(ref _leftTurnAtlasRegion);
			set => SetProperty(ref _leftTurnAtlasRegion, value);
		}

		[Ordinal(7)] 
		[RED("rightTurnAtlasRegion")] 
		public CName RightTurnAtlasRegion
		{
			get => GetProperty(ref _rightTurnAtlasRegion);
			set => SetProperty(ref _rightTurnAtlasRegion, value);
		}

		[Ordinal(8)] 
		[RED("straightTurnAtlasRegion")] 
		public CName StraightTurnAtlasRegion
		{
			get => GetProperty(ref _straightTurnAtlasRegion);
			set => SetProperty(ref _straightTurnAtlasRegion, value);
		}

		public gameuiQuadRacerPlayer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
