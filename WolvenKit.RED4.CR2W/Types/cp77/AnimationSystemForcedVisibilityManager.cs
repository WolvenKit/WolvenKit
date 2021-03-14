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
			get
			{
				if (_entities == null)
				{
					_entities = (CArray<CHandle<AnimationSystemForcedVisibilityEntityData>>) CR2WTypeManager.Create("array:handle:AnimationSystemForcedVisibilityEntityData", "entities", cr2w, this);
				}
				return _entities;
			}
			set
			{
				if (_entities == value)
				{
					return;
				}
				_entities = value;
				PropertySet(this);
			}
		}

		public AnimationSystemForcedVisibilityManager(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
