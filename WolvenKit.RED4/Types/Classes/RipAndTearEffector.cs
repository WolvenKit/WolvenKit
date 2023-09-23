using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RipAndTearEffector : ModifyDamageEffector
	{
		[Ordinal(6)] 
		[RED("sfxName")] 
		public CName SfxName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(7)] 
		[RED("vfxName")] 
		public CName VfxName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(8)] 
		[RED("statusEffectToRemove")] 
		public CString StatusEffectToRemove
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(9)] 
		[RED("prevCleanupTime")] 
		public EngineTime PrevCleanupTime
		{
			get => GetPropertyValue<EngineTime>();
			set => SetPropertyValue<EngineTime>(value);
		}

		public RipAndTearEffector()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
