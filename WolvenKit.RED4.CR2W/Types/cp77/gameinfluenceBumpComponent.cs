using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinfluenceBumpComponent : entIPlacedComponent
	{
		private CBool _isPlayerControlled;
		private CFloat _movementSpreadDistance;
		private CFloat _movementSpreadRadius;
		private CFloat _distanceToReactBack;
		private CFloat _distanceToReactFront;
		private CArray<gameinfluenceBumpReactionSetting> _reactionSettings;
		private CBool _autoPlayBumpAnimation;
		private CBool _isEnabled;
		private CBool _isBumpable;

		[Ordinal(5)] 
		[RED("isPlayerControlled")] 
		public CBool IsPlayerControlled
		{
			get => GetProperty(ref _isPlayerControlled);
			set => SetProperty(ref _isPlayerControlled, value);
		}

		[Ordinal(6)] 
		[RED("movementSpreadDistance")] 
		public CFloat MovementSpreadDistance
		{
			get => GetProperty(ref _movementSpreadDistance);
			set => SetProperty(ref _movementSpreadDistance, value);
		}

		[Ordinal(7)] 
		[RED("movementSpreadRadius")] 
		public CFloat MovementSpreadRadius
		{
			get => GetProperty(ref _movementSpreadRadius);
			set => SetProperty(ref _movementSpreadRadius, value);
		}

		[Ordinal(8)] 
		[RED("distanceToReactBack")] 
		public CFloat DistanceToReactBack
		{
			get => GetProperty(ref _distanceToReactBack);
			set => SetProperty(ref _distanceToReactBack, value);
		}

		[Ordinal(9)] 
		[RED("distanceToReactFront")] 
		public CFloat DistanceToReactFront
		{
			get => GetProperty(ref _distanceToReactFront);
			set => SetProperty(ref _distanceToReactFront, value);
		}

		[Ordinal(10)] 
		[RED("reactionSettings")] 
		public CArray<gameinfluenceBumpReactionSetting> ReactionSettings
		{
			get => GetProperty(ref _reactionSettings);
			set => SetProperty(ref _reactionSettings, value);
		}

		[Ordinal(11)] 
		[RED("autoPlayBumpAnimation")] 
		public CBool AutoPlayBumpAnimation
		{
			get => GetProperty(ref _autoPlayBumpAnimation);
			set => SetProperty(ref _autoPlayBumpAnimation, value);
		}

		[Ordinal(12)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetProperty(ref _isEnabled);
			set => SetProperty(ref _isEnabled, value);
		}

		[Ordinal(13)] 
		[RED("isBumpable")] 
		public CBool IsBumpable
		{
			get => GetProperty(ref _isBumpable);
			set => SetProperty(ref _isBumpable, value);
		}

		public gameinfluenceBumpComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
