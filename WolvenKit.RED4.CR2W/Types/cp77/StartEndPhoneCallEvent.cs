using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StartEndPhoneCallEvent : redEvent
	{
		private CFloat _callDuration;
		private CBool _startCall;
		private CEnum<gamedataStatType> _statType;
		private CEnum<gamedataStatPoolType> _statPoolType;
		private CString _statPoolName;

		[Ordinal(0)] 
		[RED("callDuration")] 
		public CFloat CallDuration
		{
			get => GetProperty(ref _callDuration);
			set => SetProperty(ref _callDuration, value);
		}

		[Ordinal(1)] 
		[RED("startCall")] 
		public CBool StartCall
		{
			get => GetProperty(ref _startCall);
			set => SetProperty(ref _startCall, value);
		}

		[Ordinal(2)] 
		[RED("statType")] 
		public CEnum<gamedataStatType> StatType
		{
			get => GetProperty(ref _statType);
			set => SetProperty(ref _statType, value);
		}

		[Ordinal(3)] 
		[RED("statPoolType")] 
		public CEnum<gamedataStatPoolType> StatPoolType
		{
			get => GetProperty(ref _statPoolType);
			set => SetProperty(ref _statPoolType, value);
		}

		[Ordinal(4)] 
		[RED("statPoolName")] 
		public CString StatPoolName
		{
			get => GetProperty(ref _statPoolName);
			set => SetProperty(ref _statPoolName, value);
		}

		public StartEndPhoneCallEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
