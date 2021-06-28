using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamemappinsDynamicQuestMappinRepInfo : CVariable
	{
		private CUInt32 _journalPathHash;
		private wCHandle<entEntity> _entity;

		[Ordinal(0)] 
		[RED("journalPathHash")] 
		public CUInt32 JournalPathHash
		{
			get => GetProperty(ref _journalPathHash);
			set => SetProperty(ref _journalPathHash, value);
		}

		[Ordinal(1)] 
		[RED("entity")] 
		public wCHandle<entEntity> Entity
		{
			get => GetProperty(ref _entity);
			set => SetProperty(ref _entity, value);
		}

		public gamemappinsDynamicQuestMappinRepInfo(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
