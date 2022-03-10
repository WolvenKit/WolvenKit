
namespace WolvenKit.RED4.Types
{
	public partial class gamedataNPCEquipmentItemsPoolEntry_Record
	{
		[RED("items")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Items
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("minLevel")]
		[REDProperty(IsIgnored = true)]
		public CInt32 MinLevel
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("weight")]
		[REDProperty(IsIgnored = true)]
		public CFloat Weight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
