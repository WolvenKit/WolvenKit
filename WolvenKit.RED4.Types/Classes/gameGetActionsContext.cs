using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameGetActionsContext : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("clearance")] 
		public CHandle<gamedeviceClearance> Clearance
		{
			get => GetPropertyValue<CHandle<gamedeviceClearance>>();
			set => SetPropertyValue<CHandle<gamedeviceClearance>>(value);
		}

		[Ordinal(1)] 
		[RED("requestorID")] 
		public entEntityID RequestorID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(2)] 
		[RED("requestType")] 
		public CEnum<gamedeviceRequestType> RequestType
		{
			get => GetPropertyValue<CEnum<gamedeviceRequestType>>();
			set => SetPropertyValue<CEnum<gamedeviceRequestType>>(value);
		}

		[Ordinal(3)] 
		[RED("actionPrereqs")] 
		public CArray<gameActionPrereqs> ActionPrereqs
		{
			get => GetPropertyValue<CArray<gameActionPrereqs>>();
			set => SetPropertyValue<CArray<gameActionPrereqs>>(value);
		}

		[Ordinal(4)] 
		[RED("interactionLayerTag")] 
		public CName InteractionLayerTag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(5)] 
		[RED("processInitiatorObject")] 
		public CWeakHandle<gameObject> ProcessInitiatorObject
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(6)] 
		[RED("ignoresAuthorization")] 
		public CBool IgnoresAuthorization
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("allowsRemoteAuthorization")] 
		public CBool AllowsRemoteAuthorization
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("ignoresRPG")] 
		public CBool IgnoresRPG
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameGetActionsContext()
		{
			RequestorID = new();
			ActionPrereqs = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
