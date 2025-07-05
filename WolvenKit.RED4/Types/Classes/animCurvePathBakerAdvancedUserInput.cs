using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animCurvePathBakerAdvancedUserInput : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("partsInputs", 3)] 
		public CStatic<animCurvePathPartInput> PartsInputs
		{
			get => GetPropertyValue<CStatic<animCurvePathPartInput>>();
			set => SetPropertyValue<CStatic<animCurvePathPartInput>>(value);
		}

		public animCurvePathBakerAdvancedUserInput()
		{
			PartsInputs = new(0);

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
