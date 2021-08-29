using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SecurityAreaTypeChangedNotification : redEvent
	{
		private CEnum<ESecurityAreaType> _previousType;
		private CEnum<ESecurityAreaType> _currentType;
		private CWeakHandle<SecurityAreaControllerPS> _area;

		[Ordinal(0)] 
		[RED("previousType")] 
		public CEnum<ESecurityAreaType> PreviousType
		{
			get => GetProperty(ref _previousType);
			set => SetProperty(ref _previousType, value);
		}

		[Ordinal(1)] 
		[RED("currentType")] 
		public CEnum<ESecurityAreaType> CurrentType
		{
			get => GetProperty(ref _currentType);
			set => SetProperty(ref _currentType, value);
		}

		[Ordinal(2)] 
		[RED("area")] 
		public CWeakHandle<SecurityAreaControllerPS> Area
		{
			get => GetProperty(ref _area);
			set => SetProperty(ref _area, value);
		}
	}
}
