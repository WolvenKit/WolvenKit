
namespace WolvenKit.RED4.Types
{
	public partial class gamedataFastTravelPoint_Record
	{
		[RED("description")]
		[REDProperty(IsIgnored = true)]
		public CString Description
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("displayName")]
		[REDProperty(IsIgnored = true)]
		public CString DisplayName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("district")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID District
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("showInWorld")]
		[REDProperty(IsIgnored = true)]
		public CBool ShowInWorld
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("showOnWorldMap")]
		[REDProperty(IsIgnored = true)]
		public CBool ShowOnWorldMap
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
