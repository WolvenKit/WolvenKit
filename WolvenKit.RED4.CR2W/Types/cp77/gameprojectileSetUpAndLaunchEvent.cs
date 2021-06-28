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
			get => GetProperty(ref _trajectoryParams);
			set => SetProperty(ref _trajectoryParams, value);
		}

		[Ordinal(5)] 
		[RED("lerpMultiplier")] 
		public CFloat LerpMultiplier
		{
			get => GetProperty(ref _lerpMultiplier);
			set => SetProperty(ref _lerpMultiplier, value);
		}

		public gameprojectileSetUpAndLaunchEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
