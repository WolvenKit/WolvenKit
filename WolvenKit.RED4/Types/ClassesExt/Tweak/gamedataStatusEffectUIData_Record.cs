
namespace WolvenKit.RED4.Types
{
	public partial class gamedataStatusEffectUIData_Record
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
		
		[RED("floatValues")]
		[REDProperty(IsIgnored = true)]
		public CArray<CFloat> FloatValues
		{
			get => GetPropertyValue<CArray<CFloat>>();
			set => SetPropertyValue<CArray<CFloat>>(value);
		}
		
		[RED("fluffText")]
		[REDProperty(IsIgnored = true)]
		public CString FluffText
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("iconPath")]
		[REDProperty(IsIgnored = true)]
		public CString IconPath
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("intValues")]
		[REDProperty(IsIgnored = true)]
		public CArray<CInt32> IntValues
		{
			get => GetPropertyValue<CArray<CInt32>>();
			set => SetPropertyValue<CArray<CInt32>>(value);
		}
		
		[RED("nameValues")]
		[REDProperty(IsIgnored = true)]
		public CArray<CName> NameValues
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}
		
		[RED("priority")]
		[REDProperty(IsIgnored = true)]
		public CFloat Priority
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("stats")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Stats
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
	}
}
