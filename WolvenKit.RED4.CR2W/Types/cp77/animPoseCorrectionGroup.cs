using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animPoseCorrectionGroup : CVariable
	{
		private CStatic<animPoseCorrection> _poseCorrections;

		[Ordinal(0)] 
		[RED("poseCorrections", 2)] 
		public CStatic<animPoseCorrection> PoseCorrections
		{
			get => GetProperty(ref _poseCorrections);
			set => SetProperty(ref _poseCorrections, value);
		}

		public animPoseCorrectionGroup(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
