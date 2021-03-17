using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_TrajectoryFromMetaPose : animAnimNode_OnePoseInput
	{
		private animTransformIndex _metaPoseTrajectoryLs;

		[Ordinal(12)] 
		[RED("metaPoseTrajectoryLs")] 
		public animTransformIndex MetaPoseTrajectoryLs
		{
			get => GetProperty(ref _metaPoseTrajectoryLs);
			set => SetProperty(ref _metaPoseTrajectoryLs, value);
		}

		public animAnimNode_TrajectoryFromMetaPose(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
