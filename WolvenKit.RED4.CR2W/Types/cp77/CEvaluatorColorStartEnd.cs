using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CEvaluatorColorStartEnd : IEvaluatorColor
	{
		private CColor _start;
		private CColor _end;

		[Ordinal(0)] 
		[RED("start")] 
		public CColor Start
		{
			get => GetProperty(ref _start);
			set => SetProperty(ref _start, value);
		}

		[Ordinal(1)] 
		[RED("end")] 
		public CColor End
		{
			get => GetProperty(ref _end);
			set => SetProperty(ref _end, value);
		}

		public CEvaluatorColorStartEnd(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
