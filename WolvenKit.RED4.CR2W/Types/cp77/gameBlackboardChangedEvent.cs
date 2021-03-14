using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameBlackboardChangedEvent : redEvent
	{
		private CHandle<gamebbScriptDefinition> _definition;
		private gamebbScriptID _id;

		[Ordinal(0)] 
		[RED("definition")] 
		public CHandle<gamebbScriptDefinition> Definition
		{
			get
			{
				if (_definition == null)
				{
					_definition = (CHandle<gamebbScriptDefinition>) CR2WTypeManager.Create("handle:gamebbScriptDefinition", "definition", cr2w, this);
				}
				return _definition;
			}
			set
			{
				if (_definition == value)
				{
					return;
				}
				_definition = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("id")] 
		public gamebbScriptID Id
		{
			get
			{
				if (_id == null)
				{
					_id = (gamebbScriptID) CR2WTypeManager.Create("gamebbScriptID", "id", cr2w, this);
				}
				return _id;
			}
			set
			{
				if (_id == value)
				{
					return;
				}
				_id = value;
				PropertySet(this);
			}
		}

		public gameBlackboardChangedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
