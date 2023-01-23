
namespace WolvenKit.RED4.Types
{
	public partial class gamedataHitPrereqCondition_Record
	{
		[RED("invert")]
		[REDProperty(IsIgnored = true)]
		public CBool Invert
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("onlyOncePerShot")]
		[REDProperty(IsIgnored = true)]
		public CBool OnlyOncePerShot
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("type")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Type
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
