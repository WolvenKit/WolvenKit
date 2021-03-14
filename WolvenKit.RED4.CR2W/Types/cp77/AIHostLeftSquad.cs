using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIHostLeftSquad : AIAIEvent
	{
		private wCHandle<AISquadScriptInterface> _squadInterface;

		[Ordinal(2)] 
		[RED("squadInterface")] 
		public wCHandle<AISquadScriptInterface> SquadInterface
		{
			get
			{
				if (_squadInterface == null)
				{
					_squadInterface = (wCHandle<AISquadScriptInterface>) CR2WTypeManager.Create("whandle:AISquadScriptInterface", "squadInterface", cr2w, this);
				}
				return _squadInterface;
			}
			set
			{
				if (_squadInterface == value)
				{
					return;
				}
				_squadInterface = value;
				PropertySet(this);
			}
		}

		public AIHostLeftSquad(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
