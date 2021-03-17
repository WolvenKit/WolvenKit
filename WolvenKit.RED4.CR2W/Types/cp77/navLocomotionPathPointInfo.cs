using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class navLocomotionPathPointInfo : CVariable
	{
		private navSerializableSplineProgression _point;
		private CUInt32 _userDataIndex;

		[Ordinal(0)] 
		[RED("point")] 
		public navSerializableSplineProgression Point
		{
			get => GetProperty(ref _point);
			set => SetProperty(ref _point, value);
		}

		[Ordinal(1)] 
		[RED("userDataIndex")] 
		public CUInt32 UserDataIndex
		{
			get => GetProperty(ref _userDataIndex);
			set => SetProperty(ref _userDataIndex, value);
		}

		public navLocomotionPathPointInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
