using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CPOMissionDataAccessPoint : CPOMissionDevice
	{
		[Ordinal(41)] 
		[RED("hasDataToDownload")] 
		public CBool HasDataToDownload
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(42)] 
		[RED("damagesPresetName")] 
		public CName DamagesPresetName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(43)] 
		[RED("factsOnDownload")] 
		public CArray<SFactToChange> FactsOnDownload
		{
			get => GetPropertyValue<CArray<SFactToChange>>();
			set => SetPropertyValue<CArray<SFactToChange>>(value);
		}

		[Ordinal(44)] 
		[RED("factsOnUpload")] 
		public CArray<SFactToChange> FactsOnUpload
		{
			get => GetPropertyValue<CArray<SFactToChange>>();
			set => SetPropertyValue<CArray<SFactToChange>>(value);
		}

		[Ordinal(45)] 
		[RED("ownerDecidesOnTransfer")] 
		public CBool OwnerDecidesOnTransfer
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public CPOMissionDataAccessPoint()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
