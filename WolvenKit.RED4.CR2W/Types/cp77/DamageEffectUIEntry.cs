using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DamageEffectUIEntry : IScriptable
	{
		private CEnum<gamedataStatType> _valueStat;
		private CEnum<gamedataStatType> _targetStat;
		private CEnum<DamageEffectDisplayType> _displayType;
		private CFloat _valueToDisplay;
		private CFloat _effectorDuration;
		private CFloat _effectorDelay;
		private CBool _isContinuous;

		[Ordinal(0)] 
		[RED("valueStat")] 
		public CEnum<gamedataStatType> ValueStat
		{
			get => GetProperty(ref _valueStat);
			set => SetProperty(ref _valueStat, value);
		}

		[Ordinal(1)] 
		[RED("targetStat")] 
		public CEnum<gamedataStatType> TargetStat
		{
			get => GetProperty(ref _targetStat);
			set => SetProperty(ref _targetStat, value);
		}

		[Ordinal(2)] 
		[RED("displayType")] 
		public CEnum<DamageEffectDisplayType> DisplayType
		{
			get => GetProperty(ref _displayType);
			set => SetProperty(ref _displayType, value);
		}

		[Ordinal(3)] 
		[RED("valueToDisplay")] 
		public CFloat ValueToDisplay
		{
			get => GetProperty(ref _valueToDisplay);
			set => SetProperty(ref _valueToDisplay, value);
		}

		[Ordinal(4)] 
		[RED("effectorDuration")] 
		public CFloat EffectorDuration
		{
			get => GetProperty(ref _effectorDuration);
			set => SetProperty(ref _effectorDuration, value);
		}

		[Ordinal(5)] 
		[RED("effectorDelay")] 
		public CFloat EffectorDelay
		{
			get => GetProperty(ref _effectorDelay);
			set => SetProperty(ref _effectorDelay, value);
		}

		[Ordinal(6)] 
		[RED("isContinuous")] 
		public CBool IsContinuous
		{
			get => GetProperty(ref _isContinuous);
			set => SetProperty(ref _isContinuous, value);
		}

		public DamageEffectUIEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
