using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnChoiceNodeNsMappinParams : ISerializable
	{
		[Ordinal(0)] 
		[RED("locationType")] 
		public CEnum<scnChoiceNodeNsMappinLocation> LocationType
		{
			get => GetPropertyValue<CEnum<scnChoiceNodeNsMappinLocation>>();
			set => SetPropertyValue<CEnum<scnChoiceNodeNsMappinLocation>>(value);
		}

		[Ordinal(1)] 
		[RED("mappinSettings")] 
		public TweakDBID MappinSettings
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public scnChoiceNodeNsMappinParams()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
