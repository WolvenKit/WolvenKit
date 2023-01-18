using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class District : IScriptable
	{
		[Ordinal(0)] 
		[RED("districtID")] 
		public TweakDBID DistrictID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(1)] 
		[RED("presetID")] 
		public TweakDBID PresetID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public District()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
