using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameGetActionsContext : RedBaseClass
	{
		private CHandle<gamedeviceClearance> _clearance;
		private entEntityID _requestorID;
		private CEnum<gamedeviceRequestType> _requestType;
		private CArray<gameActionPrereqs> _actionPrereqs;
		private CName _interactionLayerTag;
		private CWeakHandle<gameObject> _processInitiatorObject;
		private CBool _ignoresAuthorization;
		private CBool _ignoresRPG;

		[Ordinal(0)] 
		[RED("clearance")] 
		public CHandle<gamedeviceClearance> Clearance
		{
			get => GetProperty(ref _clearance);
			set => SetProperty(ref _clearance, value);
		}

		[Ordinal(1)] 
		[RED("requestorID")] 
		public entEntityID RequestorID
		{
			get => GetProperty(ref _requestorID);
			set => SetProperty(ref _requestorID, value);
		}

		[Ordinal(2)] 
		[RED("requestType")] 
		public CEnum<gamedeviceRequestType> RequestType
		{
			get => GetProperty(ref _requestType);
			set => SetProperty(ref _requestType, value);
		}

		[Ordinal(3)] 
		[RED("actionPrereqs")] 
		public CArray<gameActionPrereqs> ActionPrereqs
		{
			get => GetProperty(ref _actionPrereqs);
			set => SetProperty(ref _actionPrereqs, value);
		}

		[Ordinal(4)] 
		[RED("interactionLayerTag")] 
		public CName InteractionLayerTag
		{
			get => GetProperty(ref _interactionLayerTag);
			set => SetProperty(ref _interactionLayerTag, value);
		}

		[Ordinal(5)] 
		[RED("processInitiatorObject")] 
		public CWeakHandle<gameObject> ProcessInitiatorObject
		{
			get => GetProperty(ref _processInitiatorObject);
			set => SetProperty(ref _processInitiatorObject, value);
		}

		[Ordinal(6)] 
		[RED("ignoresAuthorization")] 
		public CBool IgnoresAuthorization
		{
			get => GetProperty(ref _ignoresAuthorization);
			set => SetProperty(ref _ignoresAuthorization, value);
		}

		[Ordinal(7)] 
		[RED("ignoresRPG")] 
		public CBool IgnoresRPG
		{
			get => GetProperty(ref _ignoresRPG);
			set => SetProperty(ref _ignoresRPG, value);
		}
	}
}
