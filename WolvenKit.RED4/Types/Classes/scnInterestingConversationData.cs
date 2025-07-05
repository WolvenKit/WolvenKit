using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnInterestingConversationData : ISerializable
	{
		[Ordinal(0)] 
		[RED("sceneFilename")] 
		public CResourceAsyncReference<scnSceneResource> SceneFilename
		{
			get => GetPropertyValue<CResourceAsyncReference<scnSceneResource>>();
			set => SetPropertyValue<CResourceAsyncReference<scnSceneResource>>(value);
		}

		[Ordinal(1)] 
		[RED("interruptionOperations")] 
		public CArray<CHandle<scnIInterruptionOperation>> InterruptionOperations
		{
			get => GetPropertyValue<CArray<CHandle<scnIInterruptionOperation>>>();
			set => SetPropertyValue<CArray<CHandle<scnIInterruptionOperation>>>(value);
		}

		public scnInterestingConversationData()
		{
			InterruptionOperations = new() { null, null };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
