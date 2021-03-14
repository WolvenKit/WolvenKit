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
			get
			{
				if (_hitShapes == null)
				{
					_hitShapes = (CArray<gameShapeData>) CR2WTypeManager.Create("array:gameShapeData", "hitShapes", cr2w, this);
				}
				return _hitShapes;
			}
			set
			{
				if (_hitShapes == value)
				{
					return;
				}
				_hitShapes = value;
				PropertySet(this);
			}
		}

		public gameQueryResult(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
