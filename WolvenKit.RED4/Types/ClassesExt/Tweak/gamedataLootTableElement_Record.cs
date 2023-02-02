
namespace WolvenKit.RED4.Types
{
	public partial class gamedataLootTableElement_Record
	{
		[RED("dropChance")]
		[REDProperty(IsIgnored = true)]
		public CFloat DropChance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("dropCountMax")]
		[REDProperty(IsIgnored = true)]
		public CInt32 DropCountMax
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("dropCountMin")]
		[REDProperty(IsIgnored = true)]
		public CInt32 DropCountMin
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("playerPrereqID")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID PlayerPrereqID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("statModifiers")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> StatModifiers
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
	}
}
