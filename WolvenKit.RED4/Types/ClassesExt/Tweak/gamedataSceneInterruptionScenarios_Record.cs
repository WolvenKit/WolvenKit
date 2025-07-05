
namespace WolvenKit.RED4.Types
{
	public partial class gamedataSceneInterruptionScenarios_Record
	{
		[RED("scenarioNames")]
		[REDProperty(IsIgnored = true)]
		public CArray<CName> ScenarioNames
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}
	}
}
