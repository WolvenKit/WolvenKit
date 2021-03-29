using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MinimalItemTooltipStatData : IScriptable
	{
		private CFloat _value;
		private CFloat _diff;
		private CString _statName;
		private CEnum<gamedataStatType> _type;
		private CBool _isPercentage;
		private CBool _roundValue;
		private CBool _displayPlus;
		private CBool _inMeters;
		private CBool _inSeconds;

		[Ordinal(0)] 
		[RED("value")] 
		public CFloat Value
		{
			get => GetProperty(ref _value);
			set => SetProperty(ref _value, value);
		}

		[Ordinal(1)] 
		[RED("diff")] 
		public CFloat Diff
		{
			get => GetProperty(ref _diff);
			set => SetProperty(ref _diff, value);
		}

		[Ordinal(2)] 
		[RED("statName")] 
		public CString StatName
		{
			get => GetProperty(ref _statName);
			set => SetProperty(ref _statName, value);
		}

		[Ordinal(3)] 
		[RED("type")] 
		public CEnum<gamedataStatType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(4)] 
		[RED("isPercentage")] 
		public CBool IsPercentage
		{
			get => GetProperty(ref _isPercentage);
			set => SetProperty(ref _isPercentage, value);
		}

		[Ordinal(5)] 
		[RED("roundValue")] 
		public CBool RoundValue
		{
			get => GetProperty(ref _roundValue);
			set => SetProperty(ref _roundValue, value);
		}

		[Ordinal(6)] 
		[RED("displayPlus")] 
		public CBool DisplayPlus
		{
			get => GetProperty(ref _displayPlus);
			set => SetProperty(ref _displayPlus, value);
		}

		[Ordinal(7)] 
		[RED("inMeters")] 
		public CBool InMeters
		{
			get => GetProperty(ref _inMeters);
			set => SetProperty(ref _inMeters, value);
		}

		[Ordinal(8)] 
		[RED("inSeconds")] 
		public CBool InSeconds
		{
			get => GetProperty(ref _inSeconds);
			set => SetProperty(ref _inSeconds, value);
		}

		public MinimalItemTooltipStatData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
