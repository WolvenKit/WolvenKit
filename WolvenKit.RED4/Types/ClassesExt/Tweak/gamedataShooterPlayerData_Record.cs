
namespace WolvenKit.RED4.Types
{
	public partial class gamedataShooterPlayerData_Record
	{
		[RED("analogThreshold")]
		[REDProperty(IsIgnored = true)]
		public CFloat AnalogThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("arTextureAtlas")]
		[REDProperty(IsIgnored = true)]
		public CResourceAsyncReference<CResource> ArTextureAtlas
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}
		
		[RED("baseMemberFollowDelay")]
		[REDProperty(IsIgnored = true)]
		public CFloat BaseMemberFollowDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("colliderAnchorPointOffset")]
		[REDProperty(IsIgnored = true)]
		public CFloat ColliderAnchorPointOffset
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("cutSceneDelay")]
		[REDProperty(IsIgnored = true)]
		public CFloat CutSceneDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("defaultWeapon")]
		[REDProperty(IsIgnored = true)]
		public CName DefaultWeapon
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("endMoveLerpTime")]
		[REDProperty(IsIgnored = true)]
		public CFloat EndMoveLerpTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("fadeTime")]
		[REDProperty(IsIgnored = true)]
		public CFloat FadeTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("gravity")]
		[REDProperty(IsIgnored = true)]
		public CFloat Gravity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("invincibleTime")]
		[REDProperty(IsIgnored = true)]
		public CFloat InvincibleTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("jumpSize")]
		[REDProperty(IsIgnored = true)]
		public Vector2 JumpSize
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}
		
		[RED("jumpSpeed")]
		[REDProperty(IsIgnored = true)]
		public CFloat JumpSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("lmgTextureAtlas")]
		[REDProperty(IsIgnored = true)]
		public CResourceAsyncReference<CResource> LmgTextureAtlas
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}
		
		[RED("lsTextureAtlas")]
		[REDProperty(IsIgnored = true)]
		public CResourceAsyncReference<CResource> LsTextureAtlas
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}
		
		[RED("maxHealth")]
		[REDProperty(IsIgnored = true)]
		public CInt32 MaxHealth
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("minOpacity")]
		[REDProperty(IsIgnored = true)]
		public CFloat MinOpacity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("mlTextureAtlas")]
		[REDProperty(IsIgnored = true)]
		public CResourceAsyncReference<CResource> MlTextureAtlas
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}
		
		[RED("movementSpeed")]
		[REDProperty(IsIgnored = true)]
		public CFloat MovementSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("proneSize")]
		[REDProperty(IsIgnored = true)]
		public Vector2 ProneSize
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}
		
		[RED("sfxDamage")]
		[REDProperty(IsIgnored = true)]
		public CName SfxDamage
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("sfxDead")]
		[REDProperty(IsIgnored = true)]
		public CName SfxDead
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("sfxJump")]
		[REDProperty(IsIgnored = true)]
		public CName SfxJump
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("sgTextureAtlas")]
		[REDProperty(IsIgnored = true)]
		public CResourceAsyncReference<CResource> SgTextureAtlas
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}
		
		[RED("squadDistanceCap")]
		[REDProperty(IsIgnored = true)]
		public CFloat SquadDistanceCap
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("startMoveLerpTime")]
		[REDProperty(IsIgnored = true)]
		public CFloat StartMoveLerpTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
