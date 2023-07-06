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

		public entISkinTargetComponent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
