using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class OperationExecutionData : IScriptable
	{
		private CName _operationName;
		private CFloat _delay;
		private CBool _resetDelay;
		private gameDelayID _delayID;
		private CBool _isDelayActive;

		[Ordinal(0)] 
		[RED("operationName")] 
		public CName OperationName
		{
			get => GetProperty(ref _operationName);
			set => SetProperty(ref _operationName, value);
		}

		[Ordinal(1)] 
		[RED("delay")] 
		public CFloat Delay
		{
			get => GetProperty(ref _delay);
			set => SetProperty(ref _delay, value);
		}

		[Ordinal(2)] 
		[RED("resetDelay")] 
		public CBool ResetDelay
		{
			get => GetProperty(ref _resetDelay);
			set => SetProperty(ref _resetDelay, value);
		}

		[Ordinal(3)] 
		[RED("delayID")] 
		public gameDelayID DelayID
		{
			get => GetProperty(ref _delayID);
			set => SetProperty(ref _delayID, value);
		}

		[Ordinal(4)] 
		[RED("isDelayActive")] 
		public CBool IsDelayActive
		{
			get => GetProperty(ref _isDelayActive);
			set => SetProperty(ref _isDelayActive, value);
		}

		public OperationExecutionData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
