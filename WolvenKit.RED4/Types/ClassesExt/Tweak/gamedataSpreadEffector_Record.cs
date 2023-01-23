
namespace WolvenKit.RED4.Types
{
	public partial class gamedataSpreadEffector_Record
	{
		[RED("effectTag")]
		[REDProperty(IsIgnored = true)]
		public CName EffectTag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("objectAction")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID ObjectAction
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("spreadToAllTargetsInTheArea")]
		[REDProperty(IsIgnored = true)]
		public CBool SpreadToAllTargetsInTheArea
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
