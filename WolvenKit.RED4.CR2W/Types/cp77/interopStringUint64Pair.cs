using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class interopStringUint64Pair : CVariable
	{
		private CString _string;
		private CUInt64 _number;

		[Ordinal(0)] 
		[RED("string")] 
		public CString String
		{
			get => GetProperty(ref _string);
			set => SetProperty(ref _string, value);
		}

		[Ordinal(1)] 
		[RED("number")] 
		public CUInt64 Number
		{
			get => GetProperty(ref _number);
			set => SetProperty(ref _number, value);
		}

		public interopStringUint64Pair(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
