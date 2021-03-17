using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class interopUint64Pair : CVariable
	{
		private CUInt64 _first;
		private CUInt64 _second;

		[Ordinal(0)] 
		[RED("first")] 
		public CUInt64 First
		{
			get => GetProperty(ref _first);
			set => SetProperty(ref _first, value);
		}

		[Ordinal(1)] 
		[RED("second")] 
		public CUInt64 Second
		{
			get => GetProperty(ref _second);
			set => SetProperty(ref _second, value);
		}

		public interopUint64Pair(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
