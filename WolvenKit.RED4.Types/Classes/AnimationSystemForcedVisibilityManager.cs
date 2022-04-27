using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AnimationSystemForcedVisibilityManager : gameScriptableSystem
	{
		[Ordinal(0)] 
		[RED("entities")] 
		public CArray<CHandle<AnimationSystemForcedVisibilityEntityData>> Entities
		{
			get => GetPropertyValue<CArray<CHandle<AnimationSystemForcedVisibilityEntityData>>>();
			set => SetPropertyValue<CArray<CHandle<AnimationSystemForcedVisibilityEntityData>>>(value);
		}

		public AnimationSystemForcedVisibilityManager()
		{
			Entities = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
