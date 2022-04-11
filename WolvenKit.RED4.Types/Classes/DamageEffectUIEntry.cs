using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DamageEffectUIEntry : IScriptable
	{
		[Ordinal(0)] 
		[RED("valueStat")] 
		public CEnum<gamedataStatType> ValueStat
		{
			get => GetPropertyValue<CEnum<gamedataStatType>>();
			set => SetPropertyValue<CEnum<gamedataStatType>>(value);
		}

		[Ordinal(1)] 
		[RED("targetStat")] 
		public CEnum<gamedataStatType> TargetStat
		{
			get => GetPropertyValue<CEnum<gamedataStatType>>();
			set => SetPropertyValue<CEnum<gamedataStatType>>(value);
		}

		[Ordinal(2)] 
		[RED("displayType")] 
		public CEnum<DamageEffectDisplayType> DisplayType
		{
			get => GetPropertyValue<CEnum<DamageEffectDisplayType>>();
			set => SetPropertyValue<CEnum<DamageEffectDisplayType>>(value);
		}

		[Ordinal(3)] 
		[RED("valueToDisplay")] 
		public CFloat ValueToDisplay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("effectorDuration")] 
		public CFloat EffectorDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("effectorDelay")] 
		public CFloat EffectorDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("isContinuous")] 
		public CBool IsContinuous
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
