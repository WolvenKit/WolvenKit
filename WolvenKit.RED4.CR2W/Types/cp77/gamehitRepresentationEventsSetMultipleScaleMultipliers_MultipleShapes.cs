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
			get
			{
				if (_scaleMultipliers == null)
				{
					_scaleMultipliers = (CArray<Vector4>) CR2WTypeManager.Create("array:Vector4", "scaleMultipliers", cr2w, this);
				}
				return _scaleMultipliers;
			}
			set
			{
				if (_scaleMultipliers == value)
				{
					return;
				}
				_scaleMultipliers = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("shapeNames")] 
		public CArray<CName> ShapeNames
		{
			get
			{
				if (_shapeNames == null)
				{
					_shapeNames = (CArray<CName>) CR2WTypeManager.Create("array:CName", "shapeNames", cr2w, this);
				}
				return _shapeNames;
			}
			set
			{
				if (_shapeNames == value)
				{
					return;
				}
				_shapeNames = value;
				PropertySet(this);
			}
		}

		public gamehitRepresentationEventsSetMultipleScaleMultipliers_MultipleShapes(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
