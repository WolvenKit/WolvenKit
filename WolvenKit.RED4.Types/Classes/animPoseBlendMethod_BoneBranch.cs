using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animPoseBlendMethod_BoneBranch : animIPoseBlendMethod
	{
		private CArray<animOverrideBlendBoneInfo> _bones;

		[Ordinal(0)] 
		[RED("bones")] 
		public CArray<animOverrideBlendBoneInfo> Bones
		{
			get => GetProperty(ref _bones);
			set => SetProperty(ref _bones, value);
		}
	}
}
