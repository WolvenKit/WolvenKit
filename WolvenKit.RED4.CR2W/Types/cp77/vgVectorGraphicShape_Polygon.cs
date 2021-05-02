using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vgVectorGraphicShape_Polygon : vgBaseVectorGraphicShape
	{
		private CArray<Vector2> _ints;

		[Ordinal(2)] 
		[RED("ints")] 
		public CArray<Vector2> Ints
		{
			get => GetProperty(ref _ints);
			set => SetProperty(ref _ints, value);
		}

		public vgVectorGraphicShape_Polygon(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
