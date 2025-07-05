
namespace WolvenKit.RED4.Types
{
	public partial class gamedataDamageType_Record
	{
		[RED("associatedStat")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID AssociatedStat
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("enumName")]
		[REDProperty(IsIgnored = true)]
		public CString EnumName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("resistances")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Resistances
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("tags")]
		[REDProperty(IsIgnored = true)]
		public CArray<CName> Tags
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}
	}
}
