using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entMarketingAnimationComponent : entIPlacedComponent
	{
		[Ordinal(5)] 
		[RED("freezeAnimations")] 
		public CBool FreezeAnimations
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("animations")] 
		public CArray<entMarketingAnimationEntry> Animations
		{
			get => GetPropertyValue<CArray<entMarketingAnimationEntry>>();
			set => SetPropertyValue<CArray<entMarketingAnimationEntry>>(value);
		}

		[Ordinal(7)] 
		[RED("enableLookAt")] 
		public CBool EnableLookAt
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("lookAtSettings")] 
		public CHandle<animLookAtPreset_FullControl> LookAtSettings
		{
			get => GetPropertyValue<CHandle<animLookAtPreset_FullControl>>();
			set => SetPropertyValue<CHandle<animLookAtPreset_FullControl>>(value);
		}

		[Ordinal(9)] 
		[RED("lookAtOrbitDistance")] 
		public CFloat LookAtOrbitDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("lookAtTargetPitch")] 
		public CFloat LookAtTargetPitch
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(11)] 
		[RED("lookAtTargetYaw")] 
		public CFloat LookAtTargetYaw
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public entMarketingAnimationComponent()
		{
			Name = "Component";
			LocalTransform = new() { Position = new() { X = new(), Y = new(), Z = new() }, Orientation = new() { R = 1.000000F } };
			FreezeAnimations = true;
			Animations = new();
			LookAtOrbitDistance = 3.000000F;
		}
	}
}
