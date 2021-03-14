using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class senseVisibleObjectTypeEvent : redEvent
	{
		private CEnum<gamedataSenseObjectType> _type;

		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<gamedataSenseObjectType> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CEnum<gamedataSenseObjectType>) CR2WTypeManager.Create("gamedataSenseObjectType", "type", cr2w, this);
				}
				return _type;
			}
			set
			{
				if (_type == value)
				{
					return;
				}
				_type = value;
				PropertySet(this);
			}
		}

		public senseVisibleObjectTypeEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
