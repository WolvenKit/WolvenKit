using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimProfilerData_Timings : CVariable
	{
		private CName _className;
		private CFloat _avarageExclusiveTimeMS;
		private CFloat _avarageInclusiveTimeMS;

		[Ordinal(0)] 
		[RED("className")] 
		public CName ClassName
		{
			get => GetProperty(ref _className);
			set => SetProperty(ref _className, value);
		}

		[Ordinal(1)] 
		[RED("avarageExclusiveTimeMS")] 
		public CFloat AvarageExclusiveTimeMS
		{
			get => GetProperty(ref _avarageExclusiveTimeMS);
			set => SetProperty(ref _avarageExclusiveTimeMS, value);
		}

		[Ordinal(2)] 
		[RED("avarageInclusiveTimeMS")] 
		public CFloat AvarageInclusiveTimeMS
		{
			get => GetProperty(ref _avarageInclusiveTimeMS);
			set => SetProperty(ref _avarageInclusiveTimeMS, value);
		}

		public animAnimProfilerData_Timings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
