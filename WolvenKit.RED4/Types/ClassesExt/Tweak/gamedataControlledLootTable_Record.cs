
namespace WolvenKit.RED4.Types
{
	public partial class gamedataControlledLootTable_Record
	{
		[RED("controlledLootSets")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> ControlledLootSets
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("maxDropsPerAttempt")]
		[REDProperty(IsIgnored = true)]
		public CInt32 MaxDropsPerAttempt
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
	}
}
