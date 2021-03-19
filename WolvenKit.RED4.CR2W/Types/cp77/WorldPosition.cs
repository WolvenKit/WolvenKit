using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WorldPosition : CVariable
	{
		private FixedPoint _x;
		private FixedPoint _y;
		private FixedPoint _z;

		[Ordinal(0)] 
		[RED("x")] 
		public FixedPoint X
		{
			get => GetProperty(ref _x);
			set => SetProperty(ref _x, value);
		}

		[Ordinal(1)] 
		[RED("y")] 
		public FixedPoint Y
		{
			get => GetProperty(ref _y);
			set => SetProperty(ref _y, value);
		}

		[Ordinal(2)] 
		[RED("z")] 
		public FixedPoint Z
		{
			get => GetProperty(ref _z);
			set => SetProperty(ref _z, value);
		}

		public WorldPosition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
