using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questTriggerCallRequest : gameScriptableSystemRequest
	{
		private CName _caller;
		private CName _addressee;
		private CEnum<questPhoneCallPhase> _callPhase;
		private CEnum<questPhoneCallMode> _callMode;

		[Ordinal(0)] 
		[RED("caller")] 
		public CName Caller
		{
			get => GetProperty(ref _caller);
			set => SetProperty(ref _caller, value);
		}

		[Ordinal(1)] 
		[RED("addressee")] 
		public CName Addressee
		{
			get => GetProperty(ref _addressee);
			set => SetProperty(ref _addressee, value);
		}

		[Ordinal(2)] 
		[RED("callPhase")] 
		public CEnum<questPhoneCallPhase> CallPhase
		{
			get => GetProperty(ref _callPhase);
			set => SetProperty(ref _callPhase, value);
		}

		[Ordinal(3)] 
		[RED("callMode")] 
		public CEnum<questPhoneCallMode> CallMode
		{
			get => GetProperty(ref _callMode);
			set => SetProperty(ref _callMode, value);
		}

		public questTriggerCallRequest(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
