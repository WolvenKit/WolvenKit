using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class physicsCollisionPresetsOverridesResource : ISerializable
	{
		private CArray<physicsCollisionPresetOverride> _overrides;

		[Ordinal(0)] 
		[RED("overrides")] 
		public CArray<physicsCollisionPresetOverride> Overrides
		{
			get => GetProperty(ref _overrides);
			set => SetProperty(ref _overrides, value);
		}

		public physicsCollisionPresetsOverridesResource(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
