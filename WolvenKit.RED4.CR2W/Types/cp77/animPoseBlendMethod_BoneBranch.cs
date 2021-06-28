using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animPoseBlendMethod_BoneBranch : animIPoseBlendMethod
	{
		private CArray<animOverrideBlendBoneInfo> _bones;

		[Ordinal(0)] 
		[RED("bones")] 
		public CArray<animOverrideBlendBoneInfo> Bones
		{
			get => GetProperty(ref _bones);
			set => SetProperty(ref _bones, value);
		}

		public animPoseBlendMethod_BoneBranch(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
