using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GeometryShapeFace : CVariable
	{
		private CArray<CUInt32> _indices;

		[Ordinal(0)] 
		[RED("indices")] 
		public CArray<CUInt32> Indices
		{
			get
			{
				if (_indices == null)
				{
					_indices = (CArray<CUInt32>) CR2WTypeManager.Create("array:Uint32", "indices", cr2w, this);
				}
				return _indices;
			}
			set
			{
				if (_indices == value)
				{
					return;
				}
				_indices = value;
				PropertySet(this);
			}
		}

		public GeometryShapeFace(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
