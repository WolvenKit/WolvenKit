using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiSetCharacterCreationDataRequest : gamePlayerScriptableSystemRequest
	{
		private TweakDBID _lifepath;
		private CArray<gameuiCharacterCustomizationAttribute> _attributes;

		[Ordinal(1)] 
		[RED("lifepath")] 
		public TweakDBID Lifepath
		{
			get => GetProperty(ref _lifepath);
			set => SetProperty(ref _lifepath, value);
		}

		[Ordinal(2)] 
		[RED("attributes")] 
		public CArray<gameuiCharacterCustomizationAttribute> Attributes
		{
			get => GetProperty(ref _attributes);
			set => SetProperty(ref _attributes, value);
		}
	}
}
