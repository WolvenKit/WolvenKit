
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAttitude_Record
	{
		[RED("group1")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Group1
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("group2")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Group2
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("value")]
		[REDProperty(IsIgnored = true)]
		public CString Value
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
	}
}
