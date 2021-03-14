using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class panelApperanceSwitchEvent : redEvent
	{
		private CName _newApperance;

		[Ordinal(0)] 
		[RED("newApperance")] 
		public CName NewApperance
		{
			get
			{
				if (_newApperance == null)
				{
					_newApperance = (CName) CR2WTypeManager.Create("CName", "newApperance", cr2w, this);
				}
				return _newApperance;
			}
			set
			{
				if (_newApperance == value)
				{
					return;
				}
				_newApperance = value;
				PropertySet(this);
			}
		}

		public panelApperanceSwitchEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
