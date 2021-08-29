using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class physicsCollisionFilterResource : ISerializable
	{
		private CResourceReference<JsonResource> _collisionPresetJson;
		private CResourceReference<JsonResource> _overridesJson;
		private CStatic<CName> _collisionGroups;
		private CStatic<CName> _queryGroups;

		[Ordinal(0)] 
		[RED("collisionPresetJson")] 
		public CResourceReference<JsonResource> CollisionPresetJson
		{
			get => GetProperty(ref _collisionPresetJson);
			set => SetProperty(ref _collisionPresetJson, value);
		}

		[Ordinal(1)] 
		[RED("overridesJson")] 
		public CResourceReference<JsonResource> OverridesJson
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
	}
}
