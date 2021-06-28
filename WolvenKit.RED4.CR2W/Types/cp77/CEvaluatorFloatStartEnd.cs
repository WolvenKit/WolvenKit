using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CEvaluatorFloatStartEnd : IEvaluatorFloat
	{
		private CFloat _start;
		private CFloat _end;

		[Ordinal(0)] 
		[RED("start")] 
		public CFloat Start
		{
			get => GetProperty(ref _start);
			set => SetProperty(ref _start, value);
		}

		[Ordinal(1)] 
		[RED("end")] 
		public CFloat End
		{
			get => GetProperty(ref _end);
			set => SetProperty(ref _end, value);
		}

		public CEvaluatorFloatStartEnd(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
