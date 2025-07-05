using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questSceneInterrupt_ConditionType : questISceneConditionType
	{
		[Ordinal(0)] 
		[RED("sceneFile")] 
		public CResourceAsyncReference<scnSceneResource> SceneFile
		{
			get => GetPropertyValue<CResourceAsyncReference<scnSceneResource>>();
			set => SetPropertyValue<CResourceAsyncReference<scnSceneResource>>(value);
		}

		[Ordinal(1)] 
		[RED("onlyInSafeMoment")] 
		public CBool OnlyInSafeMoment
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("interruptConditions")] 
		public CArray<CHandle<scnIInterruptCondition>> InterruptConditions
		{
			get => GetPropertyValue<CArray<CHandle<scnIInterruptCondition>>>();
			set => SetPropertyValue<CArray<CHandle<scnIInterruptCondition>>>(value);
		}

		public questSceneInterrupt_ConditionType()
		{
			OnlyInSafeMoment = true;
			InterruptConditions = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
