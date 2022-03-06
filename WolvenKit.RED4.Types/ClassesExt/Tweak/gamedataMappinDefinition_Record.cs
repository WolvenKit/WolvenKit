
namespace WolvenKit.RED4.Types
{
	public partial class gamedataMappinDefinition_Record
	{
		[RED("possibleVariants")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> PossibleVariants
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("showInWorld")]
		[REDProperty(IsIgnored = true)]
		public CBool ShowInWorld
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("showOnMap")]
		[REDProperty(IsIgnored = true)]
		public CBool ShowOnMap
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("showOnMinimap")]
		[REDProperty(IsIgnored = true)]
		public CBool ShowOnMinimap
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("visibilityRange")]
		[REDProperty(IsIgnored = true)]
		public CFloat VisibilityRange
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
