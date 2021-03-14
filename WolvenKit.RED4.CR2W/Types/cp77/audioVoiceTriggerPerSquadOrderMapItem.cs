using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioVoiceTriggerPerSquadOrderMapItem : CVariable
	{
		private CName _name;
		private CName _triggerName;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get
			{
				if (_name == null)
				{
					_name = (CName) CR2WTypeManager.Create("CName", "name", cr2w, this);
				}
				return _name;
			}
			set
			{
				if (_name == value)
				{
					return;
				}
				_name = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("triggerName")] 
		public CName TriggerName
		{
			get
			{
				if (_triggerName == null)
				{
					_triggerName = (CName) CR2WTypeManager.Create("CName", "triggerName", cr2w, this);
				}
				return _triggerName;
			}
			set
			{
				if (_triggerName == value)
				{
					return;
				}
				_triggerName = value;
				PropertySet(this);
			}
		}

		public audioVoiceTriggerPerSquadOrderMapItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
