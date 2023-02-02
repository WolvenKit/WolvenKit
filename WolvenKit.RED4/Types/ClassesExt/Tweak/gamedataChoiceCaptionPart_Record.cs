
namespace WolvenKit.RED4.Types
{
	public partial class gamedataChoiceCaptionPart_Record
	{
		[RED("partType")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID PartType
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
