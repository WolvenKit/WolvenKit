using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class OutputPersistentData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("currentSecurityState")] 
		public CEnum<ESecuritySystemState> CurrentSecurityState
		{
			get => GetPropertyValue<CEnum<ESecuritySystemState>>();
			set => SetPropertyValue<CEnum<ESecuritySystemState>>(value);
		}

		[Ordinal(1)] 
		[RED("breachOrigin")] 
		public CEnum<EBreachOrigin> BreachOrigin
		{
			get => GetPropertyValue<CEnum<EBreachOrigin>>();
			set => SetPropertyValue<CEnum<EBreachOrigin>>(value);
		}

		[Ordinal(2)] 
		[RED("securityStateChanged")] 
		public CBool SecurityStateChanged
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("lastKnownPosition")] 
		public Vector4 LastKnownPosition
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(4)] 
		[RED("type")] 
		public CEnum<ESecurityNotificationType> Type
		{
			get => GetPropertyValue<CEnum<ESecurityNotificationType>>();
			set => SetPropertyValue<CEnum<ESecurityNotificationType>>(value);
		}

		[Ordinal(5)] 
		[RED("areaType")] 
		public CEnum<ESecurityAreaType> AreaType
		{
			get => GetPropertyValue<CEnum<ESecurityAreaType>>();
			set => SetPropertyValue<CEnum<ESecurityAreaType>>(value);
		}

		[Ordinal(6)] 
		[RED("objectOfInterest")] 
		public entEntityID ObjectOfInterest
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(7)] 
		[RED("whoBreached")] 
		public entEntityID WhoBreached
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(8)] 
		[RED("reporter")] 
		public gamePersistentID Reporter
		{
			get => GetPropertyValue<gamePersistentID>();
			set => SetPropertyValue<gamePersistentID>(value);
		}

		[Ordinal(9)] 
		[RED("id")] 
		public CInt32 Id
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public OutputPersistentData()
		{
			LastKnownPosition = new();
			ObjectOfInterest = new();
			WhoBreached = new();
			Reporter = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
