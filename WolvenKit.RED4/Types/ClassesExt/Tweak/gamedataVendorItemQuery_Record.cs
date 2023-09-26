
namespace WolvenKit.RED4.Types
{
	public partial class gamedataVendorItemQuery_Record
	{
		[RED("query")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Query
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("uniquesOnly")]
		[REDProperty(IsIgnored = true)]
		public CBool UniquesOnly
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
