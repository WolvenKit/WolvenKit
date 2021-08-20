using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIThreatSaveData : CVariable
	{
		private entEntityID _entityId;
		private CUInt32 _persistenceSourceBitMask;

		[Ordinal(0)] 
		[RED("entityId")] 
		public entEntityID EntityId
		{
			get => GetProperty(ref _entityId);
			set => SetProperty(ref _entityId, value);
		}

		[Ordinal(1)] 
		[RED("persistenceSourceBitMask")] 
		public CUInt32 PersistenceSourceBitMask
		{
			get => GetProperty(ref _persistenceSourceBitMask);
			set => SetProperty(ref _persistenceSourceBitMask, value);
		}

		public AIThreatSaveData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
