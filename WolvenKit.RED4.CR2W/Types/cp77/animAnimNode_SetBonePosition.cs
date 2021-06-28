using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_SetBonePosition : animAnimNode_OnePoseInput
	{
		private animTransformIndex _bone;
		private animVectorLink _positionMs;

		[Ordinal(12)] 
		[RED("bone")] 
		public animTransformIndex Bone
		{
			get => GetProperty(ref _bone);
			set => SetProperty(ref _bone, value);
		}

		[Ordinal(13)] 
		[RED("positionMs")] 
		public animVectorLink PositionMs
		{
			get => GetProperty(ref _positionMs);
			set => SetProperty(ref _positionMs, value);
		}

		public animAnimNode_SetBonePosition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
