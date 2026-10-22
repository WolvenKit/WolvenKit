using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public abstract partial class entISkinTargetComponent : entIVisualComponent
	{
		[Ordinal(8)] 
		[RED("skinning")] 
		public CHandle<entSkinningBinding> Skinning
		{
			get => GetPropertyValue<CHandle<entSkinningBinding>>();
			set => SetPropertyValue<CHandle<entSkinningBinding>>(value);
		}

		[Ordinal(9)] 
		[RED("useSkinningLOD")] 
		public CBool UseSkinningLOD
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("boundingBoxLocalBoundsOverride")] 
		public CFloat BoundingBoxLocalBoundsOverride
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public entISkinTargetComponent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
