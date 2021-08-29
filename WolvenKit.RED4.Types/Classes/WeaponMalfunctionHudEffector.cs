using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class WeaponMalfunctionHudEffector : gameEffector
	{
		private CWeakHandle<gameIBlackboard> _bb;

		[Ordinal(0)] 
		[RED("bb")] 
		public CWeakHandle<gameIBlackboard> Bb
		{
			get => GetProperty(ref _bb);
			set => SetProperty(ref _bb, value);
		}
	}
}
