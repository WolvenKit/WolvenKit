using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entInstancedAnimationComponent : entISkinableComponent
	{
		private CResourceReference<animAnimSet> _animations;
		private CName _animToSample;
		private CName _variantAnimToSample;
		private CName _variantTriggerTag;

		[Ordinal(5)] 
		[RED("animations")] 
		public CResourceReference<animAnimSet> Animations
		{
			get => GetProperty(ref _animations);
			set => SetProperty(ref _animations, value);
		}

		[Ordinal(6)] 
		[RED("animToSample")] 
		public CName AnimToSample
		{
			get => GetProperty(ref _animToSample);
			set => SetProperty(ref _animToSample, value);
		}

		[Ordinal(7)] 
		[RED("variantAnimToSample")] 
		public CName VariantAnimToSample
		{
			get => GetProperty(ref _variantAnimToSample);
			set => SetProperty(ref _variantAnimToSample, value);
		}

		[Ordinal(8)] 
		[RED("variantTriggerTag")] 
		public CName VariantTriggerTag
		{
			get => GetProperty(ref _variantTriggerTag);
			set => SetProperty(ref _variantTriggerTag, value);
		}
	}
}
