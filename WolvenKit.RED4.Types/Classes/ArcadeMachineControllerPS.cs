using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ArcadeMachineControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(104)] 
		[RED("gameVideosPaths")] 
		public CArray<redResourceReferenceScriptToken> GameVideosPaths
		{
			get => GetPropertyValue<CArray<redResourceReferenceScriptToken>>();
			set => SetPropertyValue<CArray<redResourceReferenceScriptToken>>(value);
		}

		public ArcadeMachineControllerPS()
		{
			DeviceName = "LocKey#1635";
			TweakDBRecord = new() { Value = 93060634862 };
			TweakDBDescriptionRecord = new() { Value = 143953089827 };
			GameVideosPaths = new();
		}
	}
}
