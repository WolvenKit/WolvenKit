using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Vector3 : CVariable
	{
		private CFloat _x;
		private CFloat _y;
		private CFloat _z;

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

		public Vector3(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
