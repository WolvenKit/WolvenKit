
namespace WolvenKit.RED4.Types
{
	public partial class gamedataPreventionUnitPoolData_Record
	{
		[RED("characterRecord")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID CharacterRecord
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
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
