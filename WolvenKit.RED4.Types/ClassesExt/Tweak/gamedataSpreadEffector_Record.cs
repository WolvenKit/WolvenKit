
namespace WolvenKit.RED4.Types
{
	public partial class gamedataSpreadEffector_Record
	{
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
