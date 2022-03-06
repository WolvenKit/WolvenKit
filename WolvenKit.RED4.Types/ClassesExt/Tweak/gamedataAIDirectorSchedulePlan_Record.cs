
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAIDirectorSchedulePlan_Record
	{
		[RED("MinTensionToPerform")]
		[REDProperty(IsIgnored = true)]
		public CFloat MinTensionToPerform
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("spawningDesc")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID SpawningDesc
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
