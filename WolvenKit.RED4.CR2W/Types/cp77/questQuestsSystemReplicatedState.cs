using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questQuestsSystemReplicatedState : gameIGameSystemReplicatedState
	{
		private CArray<questQuestPrefabsEntry> _replicatedQuestPrefabs;

		[Ordinal(0)] 
		[RED("replicatedQuestPrefabs")] 
		public CArray<questQuestPrefabsEntry> ReplicatedQuestPrefabs
		{
			get
			{
				if (_replicatedQuestPrefabs == null)
				{
					_replicatedQuestPrefabs = (CArray<questQuestPrefabsEntry>) CR2WTypeManager.Create("array:questQuestPrefabsEntry", "replicatedQuestPrefabs", cr2w, this);
				}
				return _replicatedQuestPrefabs;
			}
			set
			{
				if (_replicatedQuestPrefabs == value)
				{
					return;
				}
				_replicatedQuestPrefabs = value;
				PropertySet(this);
			}
		}

		public questQuestsSystemReplicatedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
