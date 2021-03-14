using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class senseShapes : CVariable
	{
		private CArray<CHandle<senseIShape>> _shapes;

		[Ordinal(0)] 
		[RED("shapes")] 
		public CArray<CHandle<senseIShape>> Shapes
		{
			get
			{
				if (_shapes == null)
				{
					_shapes = (CArray<CHandle<senseIShape>>) CR2WTypeManager.Create("array:handle:senseIShape", "shapes", cr2w, this);
				}
				return _shapes;
			}
			set
			{
				if (_shapes == value)
				{
					return;
				}
				_shapes = value;
				PropertySet(this);
			}
		}

		public senseShapes(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
