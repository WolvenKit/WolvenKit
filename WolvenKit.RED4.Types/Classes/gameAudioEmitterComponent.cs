using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameAudioEmitterComponent : entIPlacedComponent
	{
		private CName _emitterName;
		private CEnum<audioEntityEmitterContextType> _emitterType;
		private gameAudioSyncs _onAttach;
		private gameAudioSyncs _onDetach;
		private CFloat _updateDistance;
		private CName _emitterMetadataName;
		private CArray<CName> _tags;
		private redTagList _tagList;

		[Ordinal(5)] 
		[RED("EmitterName")] 
		public CName EmitterName
		{
			get => GetProperty(ref _emitterName);
			set => SetProperty(ref _emitterName, value);
		}

		[Ordinal(6)] 
		[RED("EmitterType")] 
		public CEnum<audioEntityEmitterContextType> EmitterType
		{
			get => GetProperty(ref _emitterType);
			set => SetProperty(ref _emitterType, value);
		}

		[Ordinal(7)] 
		[RED("OnAttach")] 
		public gameAudioSyncs OnAttach
		{
			get => GetProperty(ref _onAttach);
			set => SetProperty(ref _onAttach, value);
		}

		[Ordinal(8)] 
		[RED("OnDetach")] 
		public gameAudioSyncs OnDetach
		{
			get => GetProperty(ref _onDetach);
			set => SetProperty(ref _onDetach, value);
		}

		[Ordinal(9)] 
		[RED("updateDistance")] 
		public CFloat UpdateDistance
		{
			get => GetProperty(ref _updateDistance);
			set => SetProperty(ref _updateDistance, value);
		}

		[Ordinal(10)] 
		[RED("emitterMetadataName")] 
		public CName EmitterMetadataName
		{
			get => GetProperty(ref _emitterMetadataName);
			set => SetProperty(ref _emitterMetadataName, value);
		}

		[Ordinal(11)] 
		[RED("Tags")] 
		public CArray<CName> Tags
		{
			get => GetProperty(ref _tags);
			set => SetProperty(ref _tags, value);
		}

		[Ordinal(12)] 
		[RED("TagList")] 
		public redTagList TagList
		{
			get => GetProperty(ref _tagList);
			set => SetProperty(ref _tagList, value);
		}

		public gameAudioEmitterComponent()
		{
			_updateDistance = 100.000000F;
		}
	}
}
