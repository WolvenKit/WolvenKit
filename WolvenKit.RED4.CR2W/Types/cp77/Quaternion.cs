using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Quaternion : CVariable
	{
		private CFloat _i;
		private CFloat _j;
		private CFloat _k;
		private CFloat _r;

		[Ordinal(0)] 
		[RED("i")] 
		public CFloat I
		{
			get => GetProperty(ref _i);
			set => SetProperty(ref _i, value);
		}

		[Ordinal(1)] 
		[RED("j")] 
		public CFloat J
		{
			get => GetProperty(ref _j);
			set => SetProperty(ref _j, value);
		}

		[Ordinal(2)] 
		[RED("k")] 
		public CFloat K
		{
			get => GetProperty(ref _k);
			set => SetProperty(ref _k, value);
		}

		[Ordinal(3)] 
		[RED("r")] 
		public CFloat R
		{
			get => GetProperty(ref _r);
			set => SetProperty(ref _r, value);
		}

		public Quaternion(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
