using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SecurityAreaData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("securityArea")] 
		public CWeakHandle<SecurityAreaControllerPS> SecurityArea
		{
			get => GetPropertyValue<CWeakHandle<SecurityAreaControllerPS>>();
			set => SetPropertyValue<CWeakHandle<SecurityAreaControllerPS>>(value);
		}

		[Ordinal(1)] 
		[RED("securityAreaType")] 
		public CEnum<ESecurityAreaType> SecurityAreaType
		{
			get => GetPropertyValue<CEnum<ESecurityAreaType>>();
			set => SetPropertyValue<CEnum<ESecurityAreaType>>(value);
		}

		[Ordinal(2)] 
		[RED("accessLevel")] 
		public CEnum<ESecurityAccessLevel> AccessLevel
		{
			get => GetPropertyValue<CEnum<ESecurityAccessLevel>>();
			set => SetPropertyValue<CEnum<ESecurityAccessLevel>>(value);
		}

		[Ordinal(3)] 
		[RED("zoneName")] 
		public CString ZoneName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(4)] 
		[RED("entered")] 
		public CBool Entered
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("id")] 
		public gamePersistentID Id
		{
			get => GetPropertyValue<gamePersistentID>();
			set => SetPropertyValue<gamePersistentID>(value);
		}

		[Ordinal(6)] 
		[RED("incomingFilters")] 
		public CEnum<EFilterType> IncomingFilters
		{
			get => GetPropertyValue<CEnum<EFilterType>>();
			set => SetPropertyValue<CEnum<EFilterType>>(value);
		}

		[Ordinal(7)] 
		[RED("outgoingFilters")] 
		public CEnum<EFilterType> OutgoingFilters
		{
			get => GetPropertyValue<CEnum<EFilterType>>();
			set => SetPropertyValue<CEnum<EFilterType>>(value);
		}

		[Ordinal(8)] 
		[RED("shouldHideOnMinimap")] 
		public CBool ShouldHideOnMinimap
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public SecurityAreaData()
		{
			Id = new gamePersistentID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
