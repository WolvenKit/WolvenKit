using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ConvexHull : CVariable
	{
		private CArray<Vector4> _planes;

		[Ordinal(0)] 
		[RED("planes")] 
		public CArray<Vector4> Planes
		{
			get
			{
				if (_planes == null)
				{
					_planes = (CArray<Vector4>) CR2WTypeManager.Create("array:Vector4", "planes", cr2w, this);
				}
				return _planes;
			}
			set
			{
				if (_planes == value)
				{
					return;
				}
				_planes = value;
				PropertySet(this);
			}
		}

		public ConvexHull(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
