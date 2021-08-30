using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class dbgSpawner : gameObject
	{
		private TweakDBID _objectRecordId;
		private CName _appearance;
		private CBool _isActive;
		private CEnum<gameAlwaysSpawnedState> _alwaysSpawned;

		[Ordinal(40)] 
		[RED("objectRecordId")] 
		public TweakDBID ObjectRecordId
		{
			get => GetProperty(ref _objectRecordId);
			set => SetProperty(ref _objectRecordId, value);
		}

		[Ordinal(41)] 
		[RED("appearance")] 
		public CName Appearance
		{
			get => GetProperty(ref _appearance);
			set => SetProperty(ref _appearance, value);
		}

		[Ordinal(42)] 
		[RED("isActive")] 
		public CBool IsActive
		{
			get => GetProperty(ref _isActive);
			set => SetProperty(ref _isActive, value);
		}

		[Ordinal(43)] 
		[RED("alwaysSpawned")] 
		public CEnum<gameAlwaysSpawnedState> AlwaysSpawned
		{
			get => GetProperty(ref _alwaysSpawned);
			set => SetProperty(ref _alwaysSpawned, value);
		}

		public dbgSpawner()
		{
			_appearance = "default";
		}
	}
}
