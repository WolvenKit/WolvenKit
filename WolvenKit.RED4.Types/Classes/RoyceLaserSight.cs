using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RoyceLaserSight : Attack_Beam
	{
		private CWeakHandle<entEntity> _previousTarget;

		[Ordinal(0)] 
		[RED("previousTarget")] 
		public CWeakHandle<entEntity> PreviousTarget
		{
			get => GetProperty(ref _previousTarget);
			set => SetProperty(ref _previousTarget, value);
		}
	}
}
