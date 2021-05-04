using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamehitRepresentationEventsSetMultipleScaleMultipliers_MultipleShapes : redEvent
	{
		private CArray<Vector4> _scaleMultipliers;
		private CArray<CName> _shapeNames;

		[Ordinal(0)] 
		[RED("scaleMultipliers")] 
		public CArray<Vector4> ScaleMultipliers
		{
			get => GetProperty(ref _scaleMultipliers);
			set => SetProperty(ref _scaleMultipliers, value);
		}

		[Ordinal(1)] 
		[RED("shapeNames")] 
		public CArray<CName> ShapeNames
		{
			get => GetProperty(ref _shapeNames);
			set => SetProperty(ref _shapeNames, value);
		}

		public gamehitRepresentationEventsSetMultipleScaleMultipliers_MultipleShapes(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
