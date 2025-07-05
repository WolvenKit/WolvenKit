using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class locVoLengthEntry : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("stringId")] 
		public CRUID StringId
		{
			get => GetPropertyValue<CRUID>();
			set => SetPropertyValue<CRUID>(value);
		}

		[Ordinal(1)] 
		[RED("femaleLength")] 
		public CFloat FemaleLength
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("maleLength")] 
		public CFloat MaleLength
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public locVoLengthEntry()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
