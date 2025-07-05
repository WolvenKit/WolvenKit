using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NumericDisplayControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(107)] 
		[RED("numberToDisplay")] 
		public CInt32 NumberToDisplay
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(108)] 
		[RED("targetNumber")] 
		public CInt32 TargetNumber
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public NumericDisplayControllerPS()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
