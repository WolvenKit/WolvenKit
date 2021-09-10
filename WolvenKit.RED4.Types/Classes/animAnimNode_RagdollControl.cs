using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_RagdollControl : animAnimNode_Base
	{
		[Ordinal(11)] 
		[RED("canRequestInertialization")] 
		public CBool CanRequestInertialization
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(12)] 
		[RED("inertializationBlendDuration")] 
		public CFloat InertializationBlendDuration
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
			InertializationBlendDuration = 1.000000F;
			InputPoseNode = new();
		}
	}
}
