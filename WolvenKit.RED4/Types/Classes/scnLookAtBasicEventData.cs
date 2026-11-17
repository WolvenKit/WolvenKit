using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnLookAtBasicEventData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("basic")] 
		public scnAnimTargetBasicData Basic
		{
			get => GetPropertyValue<scnAnimTargetBasicData>();
			set => SetPropertyValue<scnAnimTargetBasicData>(value);
		}

		[Ordinal(1)] 
		[RED("removePreviousAdvancedLookAts")] 
		public CBool RemovePreviousAdvancedLookAts
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("requests")] 
		public CArray<animLookAtRequestForPart> Requests
		{
			get => GetPropertyValue<CArray<animLookAtRequestForPart>>();
			set => SetPropertyValue<CArray<animLookAtRequestForPart>>(value);
		}

		public scnLookAtBasicEventData()
		{
			Basic = new scnAnimTargetBasicData();
			RemovePreviousAdvancedLookAts = true;
			Requests = new() { new animLookAtRequestForPart { Request = new animLookAtRequest { Limits = new animLookAtLimits { HardLimitDegrees = 270.000000F, BackLimitDegrees = 210.000000F }, Priority = -1, AdditionalParts = new(2) { new animLookAtPartRequest { PartName = "Head", Weight = 0.100000F }, new animLookAtPartRequest { PartName = "Chest", Weight = 2.000000F } } } } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
