using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiMorphInfo : gameuiCharacterCustomizationInfo
	{
		[Ordinal(14)] 
		[RED("morphNames")] 
		public CArray<gameuiIndexedMorphName> MorphNames
		{
			get => GetPropertyValue<CArray<gameuiIndexedMorphName>>();
			set => SetPropertyValue<CArray<gameuiIndexedMorphName>>(value);
		}

		public gameuiMorphInfo()
		{
			Enabled = true;
			EditTags = new();
			OnDeactivateActions = new();
			MorphNames = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
