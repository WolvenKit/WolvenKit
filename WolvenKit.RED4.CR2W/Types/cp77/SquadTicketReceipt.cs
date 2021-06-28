using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SquadTicketReceipt : CVariable
	{
		private CFloat _acknowledgedTimeStamp;
		private CFloat _conditionDeactivationCheckTimeStamp;
		private CFloat _conditionDeactivationSuccessfulCheckTimeStamp;
		private CFloat _conditionCheckRandomizedInterval;
		private entEntityID _lastRecipient;
		private CInt32 _acknowledgesInQueue;
		private CInt32 _numberOfOrders;
		private CInt32 _cooldownID;

		[Ordinal(0)] 
		[RED("acknowledgedTimeStamp")] 
		public CFloat AcknowledgedTimeStamp
		{
			get => GetProperty(ref _acknowledgedTimeStamp);
			set => SetProperty(ref _acknowledgedTimeStamp, value);
		}

		[Ordinal(1)] 
		[RED("conditionDeactivationCheckTimeStamp")] 
		public CFloat ConditionDeactivationCheckTimeStamp
		{
			get => GetProperty(ref _conditionDeactivationCheckTimeStamp);
			set => SetProperty(ref _conditionDeactivationCheckTimeStamp, value);
		}

		[Ordinal(2)] 
		[RED("conditionDeactivationSuccessfulCheckTimeStamp")] 
		public CFloat ConditionDeactivationSuccessfulCheckTimeStamp
		{
			get => GetProperty(ref _conditionDeactivationSuccessfulCheckTimeStamp);
			set => SetProperty(ref _conditionDeactivationSuccessfulCheckTimeStamp, value);
		}

		[Ordinal(3)] 
		[RED("conditionCheckRandomizedInterval")] 
		public CFloat ConditionCheckRandomizedInterval
		{
			get => GetProperty(ref _conditionCheckRandomizedInterval);
			set => SetProperty(ref _conditionCheckRandomizedInterval, value);
		}

		[Ordinal(4)] 
		[RED("lastRecipient")] 
		public entEntityID LastRecipient
		{
			get => GetProperty(ref _lastRecipient);
			set => SetProperty(ref _lastRecipient, value);
		}

		[Ordinal(5)] 
		[RED("acknowledgesInQueue")] 
		public CInt32 AcknowledgesInQueue
		{
			get => GetProperty(ref _acknowledgesInQueue);
			set => SetProperty(ref _acknowledgesInQueue, value);
		}

		[Ordinal(6)] 
		[RED("numberOfOrders")] 
		public CInt32 NumberOfOrders
		{
			get => GetProperty(ref _numberOfOrders);
			set => SetProperty(ref _numberOfOrders, value);
		}

		[Ordinal(7)] 
		[RED("cooldownID")] 
		public CInt32 CooldownID
		{
			get => GetProperty(ref _cooldownID);
			set => SetProperty(ref _cooldownID, value);
		}

		public SquadTicketReceipt(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
