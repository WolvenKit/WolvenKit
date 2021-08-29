using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TurretInitData : IScriptable
	{
		private CWeakHandle<gameObject> _turret;

		[Ordinal(0)] 
		[RED("turret")] 
		public CWeakHandle<gameObject> Turret
		{
			get => GetProperty(ref _turret);
			set => SetProperty(ref _turret, value);
		}
	}
}
