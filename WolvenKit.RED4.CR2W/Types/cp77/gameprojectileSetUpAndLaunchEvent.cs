using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameprojectileSetUpAndLaunchEvent : gameprojectileLaunchEvent
	{
		private CHandle<gameprojectileTrajectoryParams> _trajectoryParams;
		private CFloat _lerpMultiplier;

		[Ordinal(4)] 
		[RED("trajectoryParams")] 
		public CHandle<gameprojectileTrajectoryParams> TrajectoryParams
		{
			get
			{
				if (_trajectoryParams == null)
				{
					_trajectoryParams = (CHandle<gameprojectileTrajectoryParams>) CR2WTypeManager.Create("handle:gameprojectileTrajectoryParams", "trajectoryParams", cr2w, this);
				}
				return _trajectoryParams;
			}
			set
			{
				if (_trajectoryParams == value)
				{
					return;
				}
				_trajectoryParams = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("lerpMultiplier")] 
		public CFloat LerpMultiplier
		{
			get
			{
				if (_lerpMultiplier == null)
				{
					_lerpMultiplier = (CFloat) CR2WTypeManager.Create("Float", "lerpMultiplier", cr2w, this);
				}
				return _lerpMultiplier;
			}
			set
			{
				if (_lerpMultiplier == value)
				{
					return;
				}
				_lerpMultiplier = value;
				PropertySet(this);
			}
		}

		public gameprojectileSetUpAndLaunchEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
