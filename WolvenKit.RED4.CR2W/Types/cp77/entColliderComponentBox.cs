using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entColliderComponentBox : entColliderComponentShape
	{
		private Vector3 _dimensions;

		[Ordinal(1)] 
		[RED("dimensions")] 
		public Vector3 Dimensions
		{
			get
			{
				if (_dimensions == null)
				{
					_dimensions = (Vector3) CR2WTypeManager.Create("Vector3", "dimensions", cr2w, this);
				}
				return _dimensions;
			}
			set
			{
				if (_dimensions == value)
				{
					return;
				}
				_dimensions = value;
				PropertySet(this);
			}
		}

		public entColliderComponentBox(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
