using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class enteventsEntityResize : redEvent
	{
		private Vector3 _extents;

		[Ordinal(0)] 
		[RED("extents")] 
		public Vector3 Extents
		{
			get
			{
				if (_extents == null)
				{
					_extents = (Vector3) CR2WTypeManager.Create("Vector3", "extents", cr2w, this);
				}
				return _extents;
			}
			set
			{
				if (_extents == value)
				{
					return;
				}
				_extents = value;
				PropertySet(this);
			}
		}

		public enteventsEntityResize(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
