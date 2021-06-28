using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CustomValueTimeout : AITimeoutCondition
	{
		private CFloat _timeoutValue;

		[Ordinal(1)] 
		[RED("timeoutValue")] 
		public CFloat TimeoutValue
		{
			get => GetProperty(ref _timeoutValue);
			set => SetProperty(ref _timeoutValue, value);
		}

		public CustomValueTimeout(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
