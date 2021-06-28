using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entInstancedAnimationComponent : entISkinableComponent
	{
		private rRef<animAnimSet> _animations;
		private CName _animToSample;
		private CName _variantAnimToSample;
		private CName _variantTriggerTag;

		[Ordinal(5)] 
		[RED("animations")] 
		public rRef<animAnimSet> Animations
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

		public entInstancedAnimationComponent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
