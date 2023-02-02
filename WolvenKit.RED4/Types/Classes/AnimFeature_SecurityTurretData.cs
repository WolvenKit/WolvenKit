using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AnimFeature_SecurityTurretData : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("Shoot")] 
		public CBool Shoot
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("isRippedOff")] 
		public CBool IsRippedOff
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("ripOffSide")] 
		public CBool RipOffSide
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("isOverriden")] 
		public CBool IsOverriden
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AnimFeature_SecurityTurretData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
