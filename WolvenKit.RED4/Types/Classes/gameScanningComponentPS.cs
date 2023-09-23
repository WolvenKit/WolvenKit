using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameScanningComponentPS : gameComponentPS
	{
		[Ordinal(0)] 
		[RED("scanningState")] 
		public CEnum<gameScanningState> ScanningState
		{
			get => GetPropertyValue<CEnum<gameScanningState>>();
			set => SetPropertyValue<CEnum<gameScanningState>>(value);
		}

		[Ordinal(1)] 
		[RED("pctScanned")] 
		public CFloat PctScanned
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("isBlocked")] 
		public CBool IsBlocked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("storedClues")] 
		public CArray<CHandle<CluePSData>> StoredClues
		{
			get => GetPropertyValue<CArray<CHandle<CluePSData>>>();
			set => SetPropertyValue<CArray<CHandle<CluePSData>>>(value);
		}

		[Ordinal(4)] 
		[RED("isScanningDisabled")] 
		public CBool IsScanningDisabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("isDecriptionEnabled")] 
		public CBool IsDecriptionEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("objectDescriptionOverride")] 
		public CHandle<ObjectScanningDescription> ObjectDescriptionOverride
		{
			get => GetPropertyValue<CHandle<ObjectScanningDescription>>();
			set => SetPropertyValue<CHandle<ObjectScanningDescription>>(value);
		}

		public gameScanningComponentPS()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
