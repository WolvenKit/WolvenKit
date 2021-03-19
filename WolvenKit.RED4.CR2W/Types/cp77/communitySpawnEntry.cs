using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class communitySpawnEntry : ISerializable
	{
		private CName _entryName;
		private TweakDBID _characterRecordId;
		private CArray<CHandle<communitySpawnPhase>> _phases;
		private CEnum<gameSpawnInViewState> _spawnInView;
		private CArray<CHandle<communitySpawnInitializer>> _initializers;

		[Ordinal(0)] 
		[RED("entryName")] 
		public CName EntryName
		{
			get => GetProperty(ref _entryName);
			set => SetProperty(ref _entryName, value);
		}

		[Ordinal(1)] 
		[RED("characterRecordId")] 
		public TweakDBID CharacterRecordId
		{
			get => GetProperty(ref _characterRecordId);
			set => SetProperty(ref _characterRecordId, value);
		}

		[Ordinal(2)] 
		[RED("phases")] 
		public CArray<CHandle<communitySpawnPhase>> Phases
		{
			get => GetProperty(ref _phases);
			set => SetProperty(ref _phases, value);
		}

		[Ordinal(3)] 
		[RED("spawnInView")] 
		public CEnum<gameSpawnInViewState> SpawnInView
		{
			get => GetProperty(ref _spawnInView);
			set => SetProperty(ref _spawnInView, value);
		}

		[Ordinal(4)] 
		[RED("initializers")] 
		public CArray<CHandle<communitySpawnInitializer>> Initializers
		{
			get => GetProperty(ref _initializers);
			set => SetProperty(ref _initializers, value);
		}

		public communitySpawnEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
