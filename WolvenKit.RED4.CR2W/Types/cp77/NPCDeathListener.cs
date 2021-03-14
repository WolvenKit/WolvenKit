using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NPCDeathListener : gameScriptStatPoolsListener
	{
		private wCHandle<NPCPuppet> _npc;

		[Ordinal(0)] 
		[RED("npc")] 
		public wCHandle<NPCPuppet> Npc
		{
			get
			{
				if (_npc == null)
				{
					_npc = (wCHandle<NPCPuppet>) CR2WTypeManager.Create("whandle:NPCPuppet", "npc", cr2w, this);
				}
				return _npc;
			}
			set
			{
				if (_npc == value)
				{
					return;
				}
				_npc = value;
				PropertySet(this);
			}
		}

		public NPCDeathListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
