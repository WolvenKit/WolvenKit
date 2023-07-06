using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_SetBoneTransform : animAnimNode_OnePoseInput
	{
		[Ordinal(12)] 
		[RED("entries")] 
		public CArray<animSetBoneTransformEntry> Entries
		{
			get => GetPropertyValue<CArray<animSetBoneTransformEntry>>();
			set => SetPropertyValue<CArray<animSetBoneTransformEntry>>(value);
		}

		public animAnimNode_SetBoneTransform()
		{
			Id = uint.MaxValue;
			InputLink = new animPoseLink();
			Entries = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
