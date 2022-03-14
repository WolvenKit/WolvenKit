
namespace WolvenKit.RED4.Types
{
	public partial class gamedataOffMeshLinkTag_Record
	{
		[RED("isAllowed")]
		[REDProperty(IsIgnored = true)]
		public CBool IsAllowed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("prerequisites")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Prerequisites
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("tag")]
		[REDProperty(IsIgnored = true)]
		public CName Tag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
