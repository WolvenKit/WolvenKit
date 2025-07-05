
namespace WolvenKit.RED4.Types
{
	public partial class gamedataVehicleColorTemplate_Record
	{
		[RED("customDecals")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> CustomDecals
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("customIcon")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID CustomIcon
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("customMultilayers")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> CustomMultilayers
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("globalClearCoatOverrides")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID GlobalClearCoatOverrides
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("hasCustomPattern")]
		[REDProperty(IsIgnored = true)]
		public CBool HasCustomPattern
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("lightsHue")]
		[REDProperty(IsIgnored = true)]
		public CFloat LightsHue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("mainColor")]
		[REDProperty(IsIgnored = true)]
		public CArray<CInt32> MainColor
		{
			get => GetPropertyValue<CArray<CInt32>>();
			set => SetPropertyValue<CArray<CInt32>>(value);
		}
		
		[RED("matchingAppearances")]
		[REDProperty(IsIgnored = true)]
		public CArray<CName> MatchingAppearances
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}
		
		[RED("matchingColorVariant")]
		[REDProperty(IsIgnored = true)]
		public CArray<CName> MatchingColorVariant
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}
		
		[RED("partsClearCoatOverrides")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> PartsClearCoatOverrides
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("secondaryColor")]
		[REDProperty(IsIgnored = true)]
		public CArray<CInt32> SecondaryColor
		{
			get => GetPropertyValue<CArray<CInt32>>();
			set => SetPropertyValue<CArray<CInt32>>(value);
		}
	}
}
