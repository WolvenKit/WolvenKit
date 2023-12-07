using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NcartTimetableSetup : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("departFrequency")] 
		public CInt32 DepartFrequency
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("uiUpdateFrequency")] 
		public CInt32 UiUpdateFrequency
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(2)] 
		[RED("trainLines")] 
		public CArray<CInt32> TrainLines
		{
			get => GetPropertyValue<CArray<CInt32>>();
			set => SetPropertyValue<CArray<CInt32>>(value);
		}

		public NcartTimetableSetup()
		{
			DepartFrequency = 5;
			UiUpdateFrequency = 1;
			TrainLines = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
