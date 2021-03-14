using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UploadFromNPCToNPCListener : QuickHackUploadListener
	{
		private wCHandle<ScriptedPuppet> _npcPuppet;

		[Ordinal(2)] 
		[RED("npcPuppet")] 
		public wCHandle<ScriptedPuppet> NpcPuppet
		{
			get
			{
				if (_npcPuppet == null)
				{
					_npcPuppet = (wCHandle<ScriptedPuppet>) CR2WTypeManager.Create("whandle:ScriptedPuppet", "npcPuppet", cr2w, this);
				}
				return _npcPuppet;
			}
			set
			{
				if (_npcPuppet == value)
				{
					return;
				}
				_npcPuppet = value;
				PropertySet(this);
			}
		}

		public UploadFromNPCToNPCListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
