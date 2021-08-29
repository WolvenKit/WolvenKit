using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animCurvePathBakerAdvancedUserInput : RedBaseClass
	{
		private CStatic<animCurvePathPartInput> _partsInputs;

		[Ordinal(0)] 
		[RED("partsInputs", 3)] 
		public CStatic<animCurvePathPartInput> PartsInputs
		{
			get => GetProperty(ref _partsInputs);
			set => SetProperty(ref _partsInputs, value);
		}
	}
}
