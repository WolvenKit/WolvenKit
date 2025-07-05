using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entInstancedAnimationComponent : entISkinableComponent
	{
		[Ordinal(5)] 
		[RED("animations")] 
		public CResourceReference<animAnimSet> Animations
		{
			get => GetPropertyValue<CResourceReference<animAnimSet>>();
			set => SetPropertyValue<CResourceReference<animAnimSet>>(value);
		}

		[Ordinal(6)] 
		[RED("animToSample")] 
		public CName AnimToSample
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(7)] 
		[RED("variantAnimToSample")] 
		public CName VariantAnimToSample
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(8)] 
		[RED("variantTriggerTag")] 
		public CName VariantTriggerTag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public entInstancedAnimationComponent()
		{
			Name = "Component";
			LocalTransform = new WorldTransform { Position = new WorldPosition { X = new FixedPoint(), Y = new FixedPoint(), Z = new FixedPoint() }, Orientation = new Quaternion { R = 1.000000F } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
