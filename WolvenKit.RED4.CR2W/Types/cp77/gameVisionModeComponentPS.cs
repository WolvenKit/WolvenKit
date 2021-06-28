using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameVisionModeComponentPS : gameComponentPS
	{
		private CBool _hideInDefaultMode;
		private CBool _hideInFocusMode;
		private CBool _inactive;
		private CBool _questInactive;
		private CArray<CName> _questForcedModules;
		private CArray<CName> _questForcedMeshes;
		private CHandle<FocusForcedHighlightPersistentData> _storedHighlightData;

		[Ordinal(0)] 
		[RED("hideInDefaultMode")] 
		public CBool HideInDefaultMode
		{
			get => GetProperty(ref _hideInDefaultMode);
			set => SetProperty(ref _hideInDefaultMode, value);
		}

		[Ordinal(1)] 
		[RED("hideInFocusMode")] 
		public CBool HideInFocusMode
		{
			get => GetProperty(ref _hideInFocusMode);
			set => SetProperty(ref _hideInFocusMode, value);
		}

		[Ordinal(2)] 
		[RED("inactive")] 
		public CBool Inactive
		{
			get => GetProperty(ref _inactive);
			set => SetProperty(ref _inactive, value);
		}

		[Ordinal(3)] 
		[RED("questInactive")] 
		public CBool QuestInactive
		{
			get => GetProperty(ref _questInactive);
			set => SetProperty(ref _questInactive, value);
		}

		[Ordinal(4)] 
		[RED("questForcedModules")] 
		public CArray<CName> QuestForcedModules
		{
			get => GetProperty(ref _questForcedModules);
			set => SetProperty(ref _questForcedModules, value);
		}

		[Ordinal(5)] 
		[RED("questForcedMeshes")] 
		public CArray<CName> QuestForcedMeshes
		{
			get => GetProperty(ref _questForcedMeshes);
			set => SetProperty(ref _questForcedMeshes, value);
		}

		[Ordinal(6)] 
		[RED("storedHighlightData")] 
		public CHandle<FocusForcedHighlightPersistentData> StoredHighlightData
		{
			get => GetProperty(ref _storedHighlightData);
			set => SetProperty(ref _storedHighlightData, value);
		}

		public gameVisionModeComponentPS(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
