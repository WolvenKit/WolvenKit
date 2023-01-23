using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AnimFeature_RagdollState : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("isActive")] 
		public CBool IsActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("hipsPolePitch")] 
		public CFloat HipsPolePitch
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("speed")] 
		public CFloat Speed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public AnimFeature_RagdollState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
