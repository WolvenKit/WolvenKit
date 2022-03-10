
namespace WolvenKit.RED4.Types
{
	public partial class gamedataRandomPassengerEntry_Record
	{
		[RED("characterRecords")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> CharacterRecords
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("probability")]
		[REDProperty(IsIgnored = true)]
		public CFloat Probability
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("role")]
		[REDProperty(IsIgnored = true)]
		public CName Role
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("validSlotNames")]
		[REDProperty(IsIgnored = true)]
		public CArray<CName> ValidSlotNames
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}
	}
}
