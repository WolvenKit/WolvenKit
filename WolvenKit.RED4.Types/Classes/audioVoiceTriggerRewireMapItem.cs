using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioVoiceTriggerRewireMapItem : RedBaseClass
	{
		private CName _name;
		private CUInt32 _inputToBeRewiredVariationIndex;
		private CName _inputToBeActuallyPlayedName;
		private CUInt32 _inputToBeActuallyPlayedVariationIndex;
		private CBool _allowReuse;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(1)] 
		[RED("inputToBeRewiredVariationIndex")] 
		public CUInt32 InputToBeRewiredVariationIndex
		{
			get => GetProperty(ref _inputToBeRewiredVariationIndex);
			set => SetProperty(ref _inputToBeRewiredVariationIndex, value);
		}

		[Ordinal(2)] 
		[RED("inputToBeActuallyPlayedName")] 
		public CName InputToBeActuallyPlayedName
		{
			get => GetProperty(ref _inputToBeActuallyPlayedName);
			set => SetProperty(ref _inputToBeActuallyPlayedName, value);
		}

		[Ordinal(3)] 
		[RED("inputToBeActuallyPlayedVariationIndex")] 
		public CUInt32 InputToBeActuallyPlayedVariationIndex
		{
			get => GetProperty(ref _inputToBeActuallyPlayedVariationIndex);
			set => SetProperty(ref _inputToBeActuallyPlayedVariationIndex, value);
		}

		[Ordinal(4)] 
		[RED("allowReuse")] 
		public CBool AllowReuse
		{
			get => GetProperty(ref _allowReuse);
			set => SetProperty(ref _allowReuse, value);
		}
	}
}
