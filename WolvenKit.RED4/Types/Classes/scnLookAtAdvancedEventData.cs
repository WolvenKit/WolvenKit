using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnLookAtAdvancedEventData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("basic")] 
		public scnAnimTargetBasicData Basic
		{
			get => GetPropertyValue<scnAnimTargetBasicData>();
			set => SetPropertyValue<scnAnimTargetBasicData>(value);
		}

		[Ordinal(1)] 
		[RED("requests")] 
		public CArray<animLookAtRequestForPart> Requests
		{
			get => GetPropertyValue<CArray<animLookAtRequestForPart>>();
			set => SetPropertyValue<CArray<animLookAtRequestForPart>>(value);
		}

		public scnLookAtAdvancedEventData()
		{
			Basic = new scnAnimTargetBasicData();
			Requests = new() { new animLookAtRequestForPart { BodyPart = "RightHand", Request = new animLookAtRequest { Suppress = 1.000000F, Mode = 1, Priority = -1 }, AttachLeftHandToRightHand = 0, AttachRightHandToLeftHand = 0 } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
