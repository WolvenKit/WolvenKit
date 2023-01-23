
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAIDirectorSchedulePlanEnemyEntry_Record
	{
		[RED("character")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Character
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("maxAmountConcurrently")]
		[REDProperty(IsIgnored = true)]
		public CInt32 MaxAmountConcurrently
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("spawnChanceFactor")]
		[REDProperty(IsIgnored = true)]
		public CFloat SpawnChanceFactor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
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
