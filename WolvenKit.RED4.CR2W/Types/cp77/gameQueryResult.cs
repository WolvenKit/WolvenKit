using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameQueryResult : CVariable
	{
		private CArray<gameShapeData> _hitShapes;

		[Ordinal(0)] 
		[RED("hitShapes")] 
		public CArray<gameShapeData> HitShapes
		{
			get => GetProperty(ref _hitShapes);
			set => SetProperty(ref _hitShapes, value);
		}

		public gameQueryResult(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
