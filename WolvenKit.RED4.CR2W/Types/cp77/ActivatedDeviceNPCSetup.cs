using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ActivatedDeviceNPCSetup : CVariable
	{
		private NodeRef _npcSpawnerNodeRef;
		private wCHandle<NPCPuppet> _npcSpawned;

		[Ordinal(0)] 
		[RED("npcSpawnerNodeRef")] 
		public NodeRef NpcSpawnerNodeRef
		{
			get
			{
				if (_npcSpawnerNodeRef == null)
				{
					_npcSpawnerNodeRef = (NodeRef) CR2WTypeManager.Create("NodeRef", "npcSpawnerNodeRef", cr2w, this);
				}
				return _npcSpawnerNodeRef;
			}
			set
			{
				if (_npcSpawnerNodeRef == value)
				{
					return;
				}
				_npcSpawnerNodeRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("npcSpawned")] 
		public wCHandle<NPCPuppet> NpcSpawned
		{
			get
			{
				if (_npcSpawned == null)
				{
					_npcSpawned = (wCHandle<NPCPuppet>) CR2WTypeManager.Create("whandle:NPCPuppet", "npcSpawned", cr2w, this);
				}
				return _npcSpawned;
			}
			set
			{
				if (_npcSpawned == value)
				{
					return;
				}
				_npcSpawned = value;
				PropertySet(this);
			}
		}

		public ActivatedDeviceNPCSetup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
