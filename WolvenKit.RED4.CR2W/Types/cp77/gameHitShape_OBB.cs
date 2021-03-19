using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameHitShape_OBB : gameHitShapeBase
	{
		private Vector3 _dimensions;

		[Ordinal(3)] 
		[RED("dimensions")] 
		public Vector3 Dimensions
		{
			get => GetProperty(ref _dimensions);
			set => SetProperty(ref _dimensions, value);
		}

		public gameHitShape_OBB(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
