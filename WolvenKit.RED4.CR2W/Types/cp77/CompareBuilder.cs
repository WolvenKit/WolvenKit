using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CompareBuilder : IScriptable
	{
		private CFloat _fLOAT_EQUAL_EPSILON;
		private CInt32 _value;

		[Ordinal(0)] 
		[RED("FLOAT_EQUAL_EPSILON")] 
		public CFloat FLOAT_EQUAL_EPSILON
		{
			get => GetProperty(ref _fLOAT_EQUAL_EPSILON);
			set => SetProperty(ref _fLOAT_EQUAL_EPSILON, value);
		}

		[Ordinal(1)] 
		[RED("value")] 
		public CInt32 Value
		{
			get => GetProperty(ref _value);
			set => SetProperty(ref _value, value);
		}

		public CompareBuilder(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
