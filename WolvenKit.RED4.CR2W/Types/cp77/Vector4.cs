using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Vector4 : CVariable
	{
		private CFloat _x;
		private CFloat _y;
		private CFloat _z;
		private CFloat _w;

		[Ordinal(0)] 
		[RED("X")] 
		public CFloat X
		{
			get => GetProperty(ref _x);
			set => SetProperty(ref _x, value);
		}

		[Ordinal(1)] 
		[RED("Y")] 
		public CFloat Y
		{
			get => GetProperty(ref _y);
			set => SetProperty(ref _y, value);
		}

		[Ordinal(2)] 
		[RED("Z")] 
		public CFloat Z
		{
			get => GetProperty(ref _z);
			set => SetProperty(ref _z, value);
		}

		[Ordinal(3)] 
		[RED("W")] 
		public CFloat W
		{
			get => GetProperty(ref _w);
			set => SetProperty(ref _w, value);
		}

		public Vector4(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
