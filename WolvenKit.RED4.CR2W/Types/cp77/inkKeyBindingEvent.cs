using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkKeyBindingEvent : redEvent
	{
		private CName _keyName;

		[Ordinal(0)] 
		[RED("keyName")] 
		public CName KeyName
		{
			get
			{
				if (_keyName == null)
				{
					_keyName = (CName) CR2WTypeManager.Create("CName", "keyName", cr2w, this);
				}
				return _keyName;
			}
			set
			{
				if (_keyName == value)
				{
					return;
				}
				_keyName = value;
				PropertySet(this);
			}
		}

		public inkKeyBindingEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
