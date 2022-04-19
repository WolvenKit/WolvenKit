using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class physicsCollisionFilterResource : ISerializable
	{
		[Ordinal(0)] 
		[RED("collisionPresetJson")] 
		public CResourceReference<JsonResource> CollisionPresetJson
		{
			get => GetPropertyValue<CResourceReference<JsonResource>>();
			set => SetPropertyValue<CResourceReference<JsonResource>>(value);
		}

		[Ordinal(1)] 
		[RED("overridesJson")] 
		public CResourceReference<JsonResource> OverridesJson
		{
			get => GetPropertyValue<CResourceReference<JsonResource>>();
			set => SetPropertyValue<CResourceReference<JsonResource>>(value);
		}

		[Ordinal(2)] 
		[RED("queryPresetJson")] 
		public CResourceReference<JsonResource> QueryPresetJson
		{
			get => GetPropertyValue<CResourceReference<JsonResource>>();
			set => SetPropertyValue<CResourceReference<JsonResource>>(value);
		}

		[Ordinal(3)] 
		[RED("collisionGroups", 64)] 
		public CStatic<CName> CollisionGroups
		{
			get => GetPropertyValue<CStatic<CName>>();
			set => SetPropertyValue<CStatic<CName>>(value);
		}

		[Ordinal(4)] 
		[RED("queryGroups", 64)] 
		public CStatic<CName> QueryGroups
		{
			get => GetPropertyValue<CStatic<CName>>();
			set => SetPropertyValue<CStatic<CName>>(value);
		}

		public physicsCollisionFilterResource()
		{
			CollisionGroups = new(0);
			QueryGroups = new(0);

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
