using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class LinkedFocusClueData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("clueGroupID")] 
		public CName ClueGroupID
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("ownerID")] 
		public entEntityID OwnerID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(2)] 
		[RED("clueIndex")] 
		public CInt32 ClueIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(3)] 
		[RED("clueRecord")] 
		public TweakDBID ClueRecord
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(4)] 
		[RED("extendedClueRecords")] 
		public CArray<ClueRecordData> ExtendedClueRecords
		{
			get => GetPropertyValue<CArray<ClueRecordData>>();
			set => SetPropertyValue<CArray<ClueRecordData>>(value);
		}

		[Ordinal(5)] 
		[RED("isScanned")] 
		public CBool IsScanned
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("wasInspected")] 
		public CBool WasInspected
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("psData")] 
		public PSOwnerData PsData
		{
			get => GetPropertyValue<PSOwnerData>();
			set => SetPropertyValue<PSOwnerData>(value);
		}

		public LinkedFocusClueData()
		{
			OwnerID = new entEntityID();
			ExtendedClueRecords = new();
			PsData = new PSOwnerData { Id = new gamePersistentID() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
