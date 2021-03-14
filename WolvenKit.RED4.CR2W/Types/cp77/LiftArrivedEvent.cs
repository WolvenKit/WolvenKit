using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LiftArrivedEvent : redEvent
	{
		private CString _floor;

		[Ordinal(0)] 
		[RED("floor")] 
		public CString Floor
		{
			get
			{
				if (_floor == null)
				{
					_floor = (CString) CR2WTypeManager.Create("String", "floor", cr2w, this);
				}
				return _floor;
			}
			set
			{
				if (_floor == value)
				{
					return;
				}
				_floor = value;
				PropertySet(this);
			}
		}

		public LiftArrivedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
