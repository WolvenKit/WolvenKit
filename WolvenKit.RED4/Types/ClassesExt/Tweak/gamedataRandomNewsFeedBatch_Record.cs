
namespace WolvenKit.RED4.Types
{
	public partial class gamedataRandomNewsFeedBatch_Record
	{
		[RED("feedList")]
		[REDProperty(IsIgnored = true)]
		public CArray<CName> FeedList
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}
	}
}
