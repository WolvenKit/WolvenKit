using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ThreatPersistanceMemory : RedBaseClass
	{
		private CArray<CWeakHandle<entEntity>> _threats;
		private CArray<CBool> _isPersistent;

		[Ordinal(0)] 
		[RED("threats")] 
		public CArray<CWeakHandle<entEntity>> Threats
		{
			get => GetProperty(ref _threats);
			set => SetProperty(ref _threats, value);
		}

		[Ordinal(1)] 
		[RED("isPersistent")] 
		public CArray<CBool> IsPersistent
		{
			get => GetProperty(ref _isPersistent);
			set => SetProperty(ref _isPersistent, value);
		}
	}
}
