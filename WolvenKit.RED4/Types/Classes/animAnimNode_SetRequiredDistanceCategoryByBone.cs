using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_SetRequiredDistanceCategoryByBone : animAnimNode_OnePoseInput
	{
		[Ordinal(12)] 
		[RED("bone")] 
		public animTransformIndex Bone
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		public animAnimNode_SetRequiredDistanceCategoryByBone()
		{
			Id = uint.MaxValue;
			InputLink = new animPoseLink();
			Bone = new animTransformIndex();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
