using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SecurityAreaTypeChangedNotification : redEvent
	{
		[Ordinal(0)] 
		[RED("previousType")] 
		public CEnum<ESecurityAreaType> PreviousType
		{
			get => GetPropertyValue<CEnum<ESecurityAreaType>>();
			set => SetPropertyValue<CEnum<ESecurityAreaType>>(value);
		}

		[Ordinal(1)] 
		[RED("currentType")] 
		public CEnum<ESecurityAreaType> CurrentType
		{
			get => GetPropertyValue<CEnum<ESecurityAreaType>>();
			set => SetPropertyValue<CEnum<ESecurityAreaType>>(value);
		}

		[Ordinal(2)] 
		[RED("area")] 
		public CWeakHandle<SecurityAreaControllerPS> Area
		{
			get => GetPropertyValue<CWeakHandle<SecurityAreaControllerPS>>();
			set => SetPropertyValue<CWeakHandle<SecurityAreaControllerPS>>(value);
		}

		[Ordinal(3)] 
		[RED("wasScheduled")] 
		public CBool WasScheduled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public SecurityAreaTypeChangedNotification()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
