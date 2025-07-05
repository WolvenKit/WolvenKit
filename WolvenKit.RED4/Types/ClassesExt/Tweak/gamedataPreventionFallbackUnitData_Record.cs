
namespace WolvenKit.RED4.Types
{
	public partial class gamedataPreventionFallbackUnitData_Record
	{
		[RED("characterRecord")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID CharacterRecord
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("minSpawnRange")]
		[REDProperty(IsIgnored = true)]
		public CFloat MinSpawnRange
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("unitsCount")]
		[REDProperty(IsIgnored = true)]
		public CInt32 UnitsCount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
	}
}
