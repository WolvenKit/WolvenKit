using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Ref_4_5_Attributes : CVariable
	{
		private CInt32 _i;
		private CFloat _f;
		private CBool _b;
		private CInt32 _id;

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
		[RED("id")] 
		public CInt32 Id
		{
			get => GetProperty(ref _id);
			set => SetProperty(ref _id, value);
		}

		public Ref_4_5_Attributes(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
