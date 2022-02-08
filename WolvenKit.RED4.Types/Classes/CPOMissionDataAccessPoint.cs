using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CPOMissionDataAccessPoint : CPOMissionDevice
	{
		[Ordinal(45)] 
		[RED("hasDataToDownload")] 
		public CBool HasDataToDownload
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(46)] 
		[RED("damagesPresetName")] 
		public CName DamagesPresetName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(47)] 
		[RED("factsOnDownload")] 
		public CArray<SFactToChange> FactsOnDownload
		{
			get => GetPropertyValue<CArray<SFactToChange>>();
			set => SetPropertyValue<CArray<SFactToChange>>(value);
		}

		[Ordinal(48)] 
		[RED("factsOnUpload")] 
		public CArray<SFactToChange> FactsOnUpload
		{
			get => GetPropertyValue<CArray<SFactToChange>>();
			set => SetPropertyValue<CArray<SFactToChange>>(value);
		}

		[Ordinal(49)] 
		[RED("ownerDecidesOnTransfer")] 
		public CBool OwnerDecidesOnTransfer
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public CPOMissionDataAccessPoint()
		{
			HasDataToDownload = true;
			DamagesPresetName = "CPODataRaceParams";
			FactsOnDownload = new();
			FactsOnUpload = new();
		}
	}
}
