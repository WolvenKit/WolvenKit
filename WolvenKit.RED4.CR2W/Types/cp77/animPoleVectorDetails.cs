using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animPoleVectorDetails : CVariable
	{
		private animTransformIndex _targetBone;
		private Vector3 _positionOffset;

		[Ordinal(0)] 
		[RED("targetBone")] 
		public animTransformIndex TargetBone
		{
			get => GetProperty(ref _targetBone);
			set => SetProperty(ref _targetBone, value);
		}

		[Ordinal(1)] 
		[RED("positionOffset")] 
		public Vector3 PositionOffset
		{
			get => GetProperty(ref _positionOffset);
			set => SetProperty(ref _positionOffset, value);
		}

		public animPoleVectorDetails(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
