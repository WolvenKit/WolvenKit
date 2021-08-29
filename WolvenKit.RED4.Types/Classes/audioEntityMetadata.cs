using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioEntityMetadata : audioAudioMetadata
	{
		private CArray<CName> _fallbackDecorators;
		private CName _defaultPositionName;
		private CName _defaultEmitterName;
		private CName _isDefaultForEntityType;
		private CBool _preferSoundComponentPosition;
		private CInt32 _priority;
		private CName _rigMetadata;
		private CArray<audioEntityEmitterSettings> _emitterDescriptions;
		private CBool _alwaysCreateDefaultEmitter;

		[Ordinal(1)] 
		[RED("fallbackDecorators")] 
		public CArray<CName> FallbackDecorators
		{
			get => GetProperty(ref _fallbackDecorators);
			set => SetProperty(ref _fallbackDecorators, value);
		}

		[Ordinal(2)] 
		[RED("defaultPositionName")] 
		public CName DefaultPositionName
		{
			get => GetProperty(ref _defaultPositionName);
			set => SetProperty(ref _defaultPositionName, value);
		}

		[Ordinal(3)] 
		[RED("defaultEmitterName")] 
		public CName DefaultEmitterName
		{
			get => GetProperty(ref _defaultEmitterName);
			set => SetProperty(ref _defaultEmitterName, value);
		}

		[Ordinal(4)] 
		[RED("isDefaultForEntityType")] 
		public CName IsDefaultForEntityType
		{
			get => GetProperty(ref _isDefaultForEntityType);
			set => SetProperty(ref _isDefaultForEntityType, value);
		}

		[Ordinal(5)] 
		[RED("preferSoundComponentPosition")] 
		public CBool PreferSoundComponentPosition
		{
			get => GetProperty(ref _preferSoundComponentPosition);
			set => SetProperty(ref _preferSoundComponentPosition, value);
		}

		[Ordinal(6)] 
		[RED("priority")] 
		public CInt32 Priority
		{
			get => GetProperty(ref _priority);
			set => SetProperty(ref _priority, value);
		}

		[Ordinal(7)] 
		[RED("rigMetadata")] 
		public CName RigMetadata
		{
			get => GetProperty(ref _rigMetadata);
			set => SetProperty(ref _rigMetadata, value);
		}

		[Ordinal(8)] 
		[RED("emitterDescriptions")] 
		public CArray<audioEntityEmitterSettings> EmitterDescriptions
		{
			get => GetProperty(ref _emitterDescriptions);
			set => SetProperty(ref _emitterDescriptions, value);
		}

		[Ordinal(9)] 
		[RED("alwaysCreateDefaultEmitter")] 
		public CBool AlwaysCreateDefaultEmitter
		{
			get => GetProperty(ref _alwaysCreateDefaultEmitter);
			set => SetProperty(ref _alwaysCreateDefaultEmitter, value);
		}
	}
}
