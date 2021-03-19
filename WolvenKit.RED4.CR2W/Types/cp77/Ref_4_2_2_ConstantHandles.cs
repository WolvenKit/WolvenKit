using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Ref_4_2_2_ConstantHandles : IScriptable
	{
		private CInt32 _i;
		private CFloat _f;
		private CHandle<IScriptable> _s;

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
		[RED("s")] 
		public CHandle<IScriptable> S
		{
			get => GetProperty(ref _s);
			set => SetProperty(ref _s, value);
		}

		public Ref_4_2_2_ConstantHandles(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
