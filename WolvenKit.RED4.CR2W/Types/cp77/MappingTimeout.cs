using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MappingTimeout : AITimeoutCondition
	{
		private CHandle<AIArgumentMapping> _timeoutMapping;
		private CFloat _timeoutValue;

		[Ordinal(1)] 
		[RED("timeoutMapping")] 
		public CHandle<AIArgumentMapping> TimeoutMapping
		{
			get => GetProperty(ref _timeoutMapping);
			set => SetProperty(ref _timeoutMapping, value);
		}

		[Ordinal(2)] 
		[RED("timeoutValue")] 
		public CFloat TimeoutValue
		{
			get => GetProperty(ref _timeoutValue);
			set => SetProperty(ref _timeoutValue, value);
		}

		public MappingTimeout(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
