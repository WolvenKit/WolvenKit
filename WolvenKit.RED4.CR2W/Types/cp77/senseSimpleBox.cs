using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class senseSimpleBox : senseIShape
	{
		private Box _box;

		[Ordinal(1)] 
		[RED("box")] 
		public Box Box
		{
			get
			{
				if (_box == null)
				{
					_box = (Box) CR2WTypeManager.Create("Box", "box", cr2w, this);
				}
				return _box;
			}
			set
			{
				if (_box == value)
				{
					return;
				}
				_box = value;
				PropertySet(this);
			}
		}

		public senseSimpleBox(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
