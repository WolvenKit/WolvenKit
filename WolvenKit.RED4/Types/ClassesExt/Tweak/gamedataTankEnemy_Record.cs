
namespace WolvenKit.RED4.Types
{
	public partial class gamedataTankEnemy_Record
	{
		[RED("headAnchorPoint")]
		[REDProperty(IsIgnored = true)]
		public Vector2 HeadAnchorPoint
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}
		
		[RED("headParentTranslation")]
		[REDProperty(IsIgnored = true)]
		public Vector2 HeadParentTranslation
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}
		
		[RED("headTextureAtlas")]
		[REDProperty(IsIgnored = true)]
		public CResourceAsyncReference<CResource> HeadTextureAtlas
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}
		
		[RED("headTexturePart")]
		[REDProperty(IsIgnored = true)]
		public CName HeadTexturePart
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("isTracker")]
		[REDProperty(IsIgnored = true)]
		public CBool IsTracker
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("rammingDamage")]
		[REDProperty(IsIgnored = true)]
		public CInt32 RammingDamage
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("velocity")]
		[REDProperty(IsIgnored = true)]
		public CFloat Velocity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("weapon")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Weapon
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
