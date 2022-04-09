using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class HitStatusEffectPresentPrereq : GenericHitPrereq
	{
		[Ordinal(5)] 
		[RED("checkType")] 
		public CEnum<gamedataCheckType> CheckType
		{
			get => GetPropertyValue<CEnum<gamedataCheckType>>();
			set => SetPropertyValue<CEnum<gamedataCheckType>>(value);
		}

		[Ordinal(6)] 
		[RED("statusEffectParam")] 
		public CString StatusEffectParam
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(7)] 
		[RED("tag")] 
		public CName Tag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public HitStatusEffectPresentPrereq()
		{
			IsSync = true;
			PipelineStage = Enums.gameDamagePipelineStage.Process;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
