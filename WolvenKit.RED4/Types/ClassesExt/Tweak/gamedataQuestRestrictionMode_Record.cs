
namespace WolvenKit.RED4.Types
{
	public partial class gamedataQuestRestrictionMode_Record
	{
		[RED("InjectedActions")]
		[REDProperty(IsIgnored = true)]
		public CArray<CName> InjectedActions
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}
	}
}
