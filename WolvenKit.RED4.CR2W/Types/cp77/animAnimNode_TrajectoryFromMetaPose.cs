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
			get
			{
				if (_metaPoseTrajectoryLs == null)
				{
					_metaPoseTrajectoryLs = (animTransformIndex) CR2WTypeManager.Create("animTransformIndex", "metaPoseTrajectoryLs", cr2w, this);
				}
				return _metaPoseTrajectoryLs;
			}
			set
			{
				if (_metaPoseTrajectoryLs == value)
				{
					return;
				}
				_metaPoseTrajectoryLs = value;
				PropertySet(this);
			}
		}

		public animAnimNode_TrajectoryFromMetaPose(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
