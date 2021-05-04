using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_SetBoneOrientation : animAnimNode_OnePoseInput
	{
		private animTransformIndex _bone;
		private animQuaternionLink _orientationMs;

		[Ordinal(12)] 
		[RED("bone")] 
		public animTransformIndex Bone
		{
			get => GetProperty(ref _bone);
			set => SetProperty(ref _bone, value);
		}

		[Ordinal(13)] 
		[RED("orientationMs")] 
		public animQuaternionLink OrientationMs
		{
			get => GetProperty(ref _orientationMs);
			set => SetProperty(ref _orientationMs, value);
		}

		public animAnimNode_SetBoneOrientation(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
