using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AnimationSystemForcedVisibilityManager : gameScriptableSystem
	{
		private CArray<CHandle<AnimationSystemForcedVisibilityEntityData>> _entities;

		[Ordinal(0)] 
		[RED("entities")] 
		public CArray<CHandle<AnimationSystemForcedVisibilityEntityData>> Entities
		{
			get => GetProperty(ref _entities);
			set => SetProperty(ref _entities, value);
		}
	}
}
