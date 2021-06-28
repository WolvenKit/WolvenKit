using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Ref_4_2_1_Class : IScriptable
	{
		private CInt32 _constValue;

		[Ordinal(0)] 
		[RED("constValue")] 
		public CInt32 ConstValue
		{
			get => GetProperty(ref _constValue);
			set => SetProperty(ref _constValue, value);
		}

		public Ref_4_2_1_Class(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
