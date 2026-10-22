using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TonemappingModeACES : ITonemappingMode
	{
		[Ordinal(1)] 
		[RED("params")] 
		public STonemappingACESParams Params
		{
			get => GetPropertyValue<STonemappingACESParams>();
			set => SetPropertyValue<STonemappingACESParams>(value);
		}

		public TonemappingModeACES()
		{
			Params = new STonemappingACESParams();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
