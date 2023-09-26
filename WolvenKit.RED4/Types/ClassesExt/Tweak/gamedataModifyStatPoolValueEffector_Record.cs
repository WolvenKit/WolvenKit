
namespace WolvenKit.RED4.Types
{
	public partial class gamedataModifyStatPoolValueEffector_Record
	{
		[RED("setValue")]
		[REDProperty(IsIgnored = true)]
		public CBool SetValue
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("statPoolUpdates")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> StatPoolUpdates
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("usePercent")]
		[REDProperty(IsIgnored = true)]
		public CBool UsePercent
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
