using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_RotateBoneByQuaternion : animAnimNode_Base
	{
		[Ordinal(11)] 
		[RED("inputNode")] 
		public animPoseLink InputNode
		{
			get => GetPropertyValue<animPoseLink>();
			set => SetPropertyValue<animPoseLink>(value);
		}

		[Ordinal(12)] 
		[RED("quaternionNode")] 
		public animQuaternionLink QuaternionNode
		{
			get => GetPropertyValue<animQuaternionLink>();
			set => SetPropertyValue<animQuaternionLink>(value);
		}

		[Ordinal(13)] 
		[RED("bone")] 
		public animTransformIndex Bone
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(14)] 
		[RED("useIncrementalMode")] 
		public CBool UseIncrementalMode
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(15)] 
		[RED("resetOnActivation")] 
		public CBool ResetOnActivation
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public animAnimNode_RotateBoneByQuaternion()
		{
			Id = uint.MaxValue;
			InputNode = new animPoseLink();
			QuaternionNode = new animQuaternionLink();
			Bone = new animTransformIndex();
			ResetOnActivation = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
