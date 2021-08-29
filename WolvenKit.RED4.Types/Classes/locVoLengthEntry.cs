using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class locVoLengthEntry : RedBaseClass
	{
		private CRUID _stringId;
		private CFloat _femaleLength;
		private CFloat _maleLength;

		[Ordinal(0)] 
		[RED("stringId")] 
		public CRUID StringId
		{
			get => GetProperty(ref _stringId);
			set => SetProperty(ref _stringId, value);
		}

		[Ordinal(1)] 
		[RED("femaleLength")] 
		public CFloat FemaleLength
		{
			get => GetProperty(ref _femaleLength);
			set => SetProperty(ref _femaleLength, value);
		}

		[Ordinal(2)] 
		[RED("maleLength")] 
		public CFloat MaleLength
		{
			get => GetProperty(ref _maleLength);
			set => SetProperty(ref _maleLength, value);
		}
	}
}
