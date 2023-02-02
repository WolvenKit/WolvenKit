using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameinfluenceBumpComponent : entIPlacedComponent
	{
		[Ordinal(5)] 
		[RED("isPlayerControlled")] 
		public CBool IsPlayerControlled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("movementSpreadDistance")] 
		public CFloat MovementSpreadDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("movementSpreadRadius")] 
		public CFloat MovementSpreadRadius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("distanceToReactBack")] 
		public CFloat DistanceToReactBack
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(9)] 
		[RED("distanceToReactFront")] 
		public CFloat DistanceToReactFront
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("reactionSettings")] 
		public CArray<gameinfluenceBumpReactionSetting> ReactionSettings
		{
			get => GetPropertyValue<CArray<gameinfluenceBumpReactionSetting>>();
			set => SetPropertyValue<CArray<gameinfluenceBumpReactionSetting>>(value);
		}

		[Ordinal(11)] 
		[RED("autoPlayBumpAnimation")] 
		public CBool AutoPlayBumpAnimation
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(12)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(13)] 
		[RED("isBumpable")] 
		public CBool IsBumpable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameinfluenceBumpComponent()
		{
			Name = "Component";
			LocalTransform = new() { Position = new() { X = new(), Y = new(), Z = new() }, Orientation = new() { R = 1.000000F } };
			MovementSpreadDistance = 2.000000F;
			MovementSpreadRadius = 0.750000F;
			DistanceToReactBack = 0.600000F;
			DistanceToReactFront = 1.000000F;
			ReactionSettings = new();
			AutoPlayBumpAnimation = true;
			IsEnabled = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
