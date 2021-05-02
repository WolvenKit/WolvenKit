using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Point3D : CVariable
	{
		private CInt32 _x;
		private CInt32 _y;
		private CInt32 _z;

		[Ordinal(0)] 
		[RED("x")] 
		public CInt32 X
		{
			get => GetProperty(ref _x);
			set => SetProperty(ref _x, value);
		}

		[Ordinal(1)] 
		[RED("y")] 
		public CInt32 Y
		{
			get => GetProperty(ref _y);
			set => SetProperty(ref _y, value);
		}

		[Ordinal(2)] 
		[RED("z")] 
		public CInt32 Z
		{
			get => GetProperty(ref _z);
			set => SetProperty(ref _z, value);
		}

		public Point3D(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
