using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_SetBonePosition : animAnimNode_OnePoseInput
	{
		[Ordinal(12)] 
		[RED("bone")] 
		public animTransformIndex Bone
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(13)] 
		[RED("positionMs")] 
		public animVectorLink PositionMs
		{
			get => GetPropertyValue<animVectorLink>();
			set => SetPropertyValue<animVectorLink>(value);
		}

		public animAnimNode_SetBonePosition()
		{
			Id = uint.MaxValue;
			InputLink = new animPoseLink();
			Bone = new animTransformIndex();
			PositionMs = new animVectorLink();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
