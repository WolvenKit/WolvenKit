using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamehitRepresentationEventsSetSingleScaleMultiplier_MultipleShapes : gamehitRepresentationEventsSetSingleScaleMultiplier_AllShapes
	{
		private CArray<CName> _shapeNames;

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

		public gamehitRepresentationEventsSetSingleScaleMultiplier_MultipleShapes(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
