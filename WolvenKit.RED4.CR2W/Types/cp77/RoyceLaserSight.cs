using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RoyceLaserSight : Attack_Beam
	{
		private wCHandle<entEntity> _previousTarget;

		[Ordinal(0)] 
		[RED("previousTarget")] 
		public wCHandle<entEntity> PreviousTarget
		{
			get => GetProperty(ref _previousTarget);
			set => SetProperty(ref _previousTarget, value);
		}

		public RoyceLaserSight(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
