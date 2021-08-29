using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameprojectileHitEvent : redEvent
	{
		private CArray<gameprojectileHitInstance> _hitInstances;

		[Ordinal(0)] 
		[RED("hitInstances")] 
		public CArray<gameprojectileHitInstance> HitInstances
		{
			get => GetProperty(ref _hitInstances);
			set => SetProperty(ref _hitInstances, value);
		}
	}
}
