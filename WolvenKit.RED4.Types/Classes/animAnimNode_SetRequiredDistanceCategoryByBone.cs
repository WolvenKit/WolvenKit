using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
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
			Id = 4294967295;
			InputLink = new();
			Bone = new();
		}
	}
}
