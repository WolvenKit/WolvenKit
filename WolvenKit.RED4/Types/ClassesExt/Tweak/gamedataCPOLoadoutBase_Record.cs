
namespace WolvenKit.RED4.Types
{
	public partial class gamedataCPOLoadoutBase_Record
	{
		[RED("displayName")]
		[REDProperty(IsIgnored = true)]
		public CString DisplayName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("items")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Items
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
	}
}
