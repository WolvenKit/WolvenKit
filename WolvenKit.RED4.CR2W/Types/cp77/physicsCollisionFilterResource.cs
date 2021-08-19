using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class physicsCollisionFilterResource : ISerializable
	{
		private rRef<JsonResource> _collisionPresetJson;
		private rRef<JsonResource> _overridesJson;
		private CStatic<CName> _collisionGroups;
		private CStatic<CName> _queryGroups;

		[Ordinal(0)] 
		[RED("collisionPresetJson")] 
		public rRef<JsonResource> CollisionPresetJson
		{
			get => GetProperty(ref _collisionPresetJson);
			set => SetProperty(ref _collisionPresetJson, value);
		}

		[Ordinal(1)] 
		[RED("overridesJson")] 
		public rRef<JsonResource> OverridesJson
		{
			get => GetProperty(ref _overridesJson);
			set => SetProperty(ref _overridesJson, value);
		}

		[Ordinal(2)] 
		[RED("collisionGroups", 64)] 
		public CStatic<CName> CollisionGroups
		{
			get => GetProperty(ref _collisionGroups);
			set => SetProperty(ref _collisionGroups, value);
		}

		[Ordinal(3)] 
		[RED("queryGroups", 64)] 
		public CStatic<CName> QueryGroups
		{
			get => GetProperty(ref _queryGroups);
			set => SetProperty(ref _queryGroups, value);
		}

		public physicsCollisionFilterResource(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
