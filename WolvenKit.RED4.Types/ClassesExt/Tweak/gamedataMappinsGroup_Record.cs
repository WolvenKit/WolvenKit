
namespace WolvenKit.RED4.Types
{
	public partial class gamedataMappinsGroup_Record
	{
		[RED("groupName")]
		[REDProperty(IsIgnored = true)]
		public CName GroupName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("mappins")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Mappins
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("widgetState")]
		[REDProperty(IsIgnored = true)]
		public CName WidgetState
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
