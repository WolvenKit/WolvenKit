using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class localizationPersistenceSubtitleEntry : RedBaseClass
	{
		private CRUID _stringId;
		private CString _femaleVariant;
		private CString _maleVariant;

		[Ordinal(0)] 
		[RED("stringId")] 
		public CRUID StringId
		{
			get => GetProperty(ref _stringId);
			set => SetProperty(ref _stringId, value);
		}

		[Ordinal(1)] 
		[RED("femaleVariant")] 
		public CString FemaleVariant
		{
			get => GetProperty(ref _femaleVariant);
			set => SetProperty(ref _femaleVariant, value);
		}

		[Ordinal(2)] 
		[RED("maleVariant")] 
		public CString MaleVariant
		{
			get => GetProperty(ref _maleVariant);
			set => SetProperty(ref _maleVariant, value);
		}
	}
}
