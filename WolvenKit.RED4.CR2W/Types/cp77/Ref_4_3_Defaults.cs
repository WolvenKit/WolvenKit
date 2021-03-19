using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Ref_4_3_Defaults : CVariable
	{
		private CInt32 _i;
		private CFloat _f;
		private CBool _b;
		private CString _s;

		[Ordinal(0)] 
		[RED("i")] 
		public CInt32 I
		{
			get => GetProperty(ref _i);
			set => SetProperty(ref _i, value);
		}

		[Ordinal(1)] 
		[RED("f")] 
		public CFloat F
		{
			get => GetProperty(ref _f);
			set => SetProperty(ref _f, value);
		}

		[Ordinal(2)] 
		[RED("b")] 
		public CBool B
		{
			get => GetProperty(ref _b);
			set => SetProperty(ref _b, value);
		}

		[Ordinal(3)] 
		[RED("s")] 
		public CString S
		{
			get => GetProperty(ref _s);
			set => SetProperty(ref _s, value);
		}

		public Ref_4_3_Defaults(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
