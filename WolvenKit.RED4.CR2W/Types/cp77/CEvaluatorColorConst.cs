using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CEvaluatorColorConst : IEvaluatorColor
	{
		private CColor _value;

		[Ordinal(0)] 
		[RED("value")] 
		public CColor Value
		{
			get => GetProperty(ref _value);
			set => SetProperty(ref _value, value);
		}

		public CEvaluatorColorConst(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
