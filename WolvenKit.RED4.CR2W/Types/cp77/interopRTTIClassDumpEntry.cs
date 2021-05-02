using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class interopRTTIClassDumpEntry : CVariable
	{
		private CInt32 _i;
		private CInt32 _b;
		private CInt32 _r;
		private CInt32 _a;

		[Ordinal(0)] 
		[RED("i")] 
		public CInt32 I
		{
			get => GetProperty(ref _i);
			set => SetProperty(ref _i, value);
		}

		[Ordinal(1)] 
		[RED("b")] 
		public CInt32 B
		{
			get => GetProperty(ref _b);
			set => SetProperty(ref _b, value);
		}

		[Ordinal(2)] 
		[RED("r")] 
		public CInt32 R
		{
			get => GetProperty(ref _r);
			set => SetProperty(ref _r, value);
		}

		[Ordinal(3)] 
		[RED("a")] 
		public CInt32 A
		{
			get => GetProperty(ref _a);
			set => SetProperty(ref _a, value);
		}

		public interopRTTIClassDumpEntry(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
