using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimationSystemForcedVisibilityManager : gameScriptableSystem
	{
		private CArray<CHandle<AnimationSystemForcedVisibilityEntityData>> _entities;

		[Ordinal(0)] 
		[RED("entities")] 
		public CArray<CHandle<AnimationSystemForcedVisibilityEntityData>> Entities
		{
			get => GetProperty(ref _entities);
			set => SetProperty(ref _entities, value);
		}

		public AnimationSystemForcedVisibilityManager(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
