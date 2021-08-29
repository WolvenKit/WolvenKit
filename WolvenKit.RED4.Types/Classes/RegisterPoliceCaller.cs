using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RegisterPoliceCaller : gameScriptableSystemRequest
	{
		private CWeakHandle<entEntity> _caller;
		private Vector4 _crimePosition;

		[Ordinal(0)] 
		[RED("caller")] 
		public CWeakHandle<entEntity> Caller
		{
			get => GetProperty(ref _caller);
			set => SetProperty(ref _caller, value);
		}

		[Ordinal(1)] 
		[RED("crimePosition")] 
		public Vector4 CrimePosition
		{
			get => GetProperty(ref _crimePosition);
			set => SetProperty(ref _crimePosition, value);
		}
	}
}
