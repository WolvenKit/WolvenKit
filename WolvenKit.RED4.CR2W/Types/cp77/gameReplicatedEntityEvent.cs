using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameReplicatedEntityEvent : entReplicatedItem
	{
		private CHandle<redEvent> _value;

		[Ordinal(2)] 
		[RED("value")] 
		public CHandle<redEvent> Value
		{
			get
			{
				if (_value == null)
				{
					_value = (CHandle<redEvent>) CR2WTypeManager.Create("handle:redEvent", "value", cr2w, this);
				}
				return _value;
			}
			set
			{
				if (_value == value)
				{
					return;
				}
				_value = value;
				PropertySet(this);
			}
		}

		public gameReplicatedEntityEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
