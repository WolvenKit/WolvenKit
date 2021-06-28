using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameJournalPointOfInterestMappin : gameJournalEntry
	{
		private NodeRef _staticNodeRef;
		private gameEntityReference _dynamicEntityRef;
		private NodeRef _securityAreaRef;
		private gamemappinsPointOfInterestMappinData _mappinData;
		private Vector3 _offset;
		private CHandle<gameJournalPath> _questPath;
		private TweakDBID _recommendedLevelID;
		private NodeRef _notificationTriggerAreaRef;

		[Ordinal(1)] 
		[RED("staticNodeRef")] 
		public NodeRef StaticNodeRef
		{
			get => GetProperty(ref _staticNodeRef);
			set => SetProperty(ref _staticNodeRef, value);
		}

		[Ordinal(2)] 
		[RED("dynamicEntityRef")] 
		public gameEntityReference DynamicEntityRef
		{
			get => GetProperty(ref _dynamicEntityRef);
			set => SetProperty(ref _dynamicEntityRef, value);
		}

		[Ordinal(3)] 
		[RED("securityAreaRef")] 
		public NodeRef SecurityAreaRef
		{
			get => GetProperty(ref _securityAreaRef);
			set => SetProperty(ref _securityAreaRef, value);
		}

		[Ordinal(4)] 
		[RED("mappinData")] 
		public gamemappinsPointOfInterestMappinData MappinData
		{
			get => GetProperty(ref _mappinData);
			set => SetProperty(ref _mappinData, value);
		}

		[Ordinal(5)] 
		[RED("offset")] 
		public Vector3 Offset
		{
			get => GetProperty(ref _offset);
			set => SetProperty(ref _offset, value);
		}

		[Ordinal(6)] 
		[RED("questPath")] 
		public CHandle<gameJournalPath> QuestPath
		{
			get => GetProperty(ref _questPath);
			set => SetProperty(ref _questPath, value);
		}

		[Ordinal(7)] 
		[RED("recommendedLevelID")] 
		public TweakDBID RecommendedLevelID
		{
			get => GetProperty(ref _recommendedLevelID);
			set => SetProperty(ref _recommendedLevelID, value);
		}

		[Ordinal(8)] 
		[RED("notificationTriggerAreaRef")] 
		public NodeRef NotificationTriggerAreaRef
		{
			get => GetProperty(ref _notificationTriggerAreaRef);
			set => SetProperty(ref _notificationTriggerAreaRef, value);
		}

		public gameJournalPointOfInterestMappin(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
