using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animPoseBlendMethod_BoneBranch : animIPoseBlendMethod
	{
		[Ordinal(0)] 
		[RED("bones")] 
		public CArray<animOverrideBlendBoneInfo> Bones
		{
			get => GetPropertyValue<CArray<animOverrideBlendBoneInfo>>();
			set => SetPropertyValue<CArray<animOverrideBlendBoneInfo>>(value);
		}

		public animPoseBlendMethod_BoneBranch()
		{
			Bones = new();
		}
	}
}
