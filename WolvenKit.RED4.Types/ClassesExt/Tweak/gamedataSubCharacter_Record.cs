
namespace WolvenKit.RED4.Types
{
	public partial class gamedataSubCharacter_Record
	{
		[RED("enumComment")]
		[REDProperty(IsIgnored = true)]
		public CString EnumComment
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("enumName")]
		[REDProperty(IsIgnored = true)]
		public CName EnumName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("isPrevention")]
		[REDProperty(IsIgnored = true)]
		public CBool IsPrevention
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("referenceName")]
		[REDProperty(IsIgnored = true)]
		public CName ReferenceName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("startingEquippedItems")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> StartingEquippedItems
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
	}
}
