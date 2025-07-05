using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questSetLocationName_NodeType : questIUIManagerNodeType
	{
		[Ordinal(0)] 
		[RED("locationName")] 
		public CString LocationName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(1)] 
		[RED("action")] 
		public CEnum<questLocationAction> Action
		{
			get => GetPropertyValue<CEnum<questLocationAction>>();
			set => SetPropertyValue<CEnum<questLocationAction>>(value);
		}

		[Ordinal(2)] 
		[RED("districtID")] 
		public TweakDBID DistrictID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(3)] 
		[RED("isNewLocation")] 
		public CBool IsNewLocation
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questSetLocationName_NodeType()
		{
			IsNewLocation = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
