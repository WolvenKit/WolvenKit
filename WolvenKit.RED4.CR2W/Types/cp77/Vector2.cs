using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Vector2 : CVariable
	{
		private CFloat _x;
		private CFloat _y;

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

		public Vector2(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
