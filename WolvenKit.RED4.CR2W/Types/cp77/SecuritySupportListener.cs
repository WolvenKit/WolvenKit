using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SecuritySupportListener : AIScriptsTargetTrackingListener
	{
		private wCHandle<ScriptedPuppet> _npc;

		[Ordinal(0)] 
		[RED("npc")] 
		public wCHandle<ScriptedPuppet> Npc
		{
			get
			{
				if (_npc == null)
				{
					_npc = (wCHandle<ScriptedPuppet>) CR2WTypeManager.Create("whandle:ScriptedPuppet", "npc", cr2w, this);
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

		public SecuritySupportListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
