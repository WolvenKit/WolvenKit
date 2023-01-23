using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_RagdollControl : animAnimNode_Base
	{
		[Ordinal(11)] 
		[RED("blendInDuration")] 
		public CFloat BlendInDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(12)] 
		[RED("blendOutDuration")] 
		public CFloat BlendOutDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(13)] 
		[RED("inputPoseNode")] 
		public animPoseLink InputPoseNode
		{
			get => GetPropertyValue<animPoseLink>();
			set => SetPropertyValue<animPoseLink>(value);
		}

		public animAnimNode_RagdollControl()
		{
			Id = 4294967295;
			BlendInDuration = 0.200000F;
			BlendOutDuration = 0.500000F;
			InputPoseNode = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
