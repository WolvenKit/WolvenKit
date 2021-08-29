using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TonemappingModeACES : ITonemappingMode
	{
		private STonemappingACESParams _params;

		[Ordinal(1)] 
		[RED("params")] 
		public STonemappingACESParams Params
		{
			get => GetProperty(ref _params);
			set => SetProperty(ref _params, value);
		}
	}
}
