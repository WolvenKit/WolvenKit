using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioVoiceTriggerLimits : CVariable
	{
		private CFloat _probability;
		private CFloat _singleNpcMinRepeatTime;
		private CFloat _allNpcsMinRepeatTime;
		private CFloat _allNpcsSharingVoicesetMinRepeatTime;
		private CFloat _combatVolume;

		[Ordinal(0)] 
		[RED("probability")] 
		public CFloat Probability
		{
			get => GetProperty(ref _probability);
			set => SetProperty(ref _probability, value);
		}

		[Ordinal(1)] 
		[RED("singleNpcMinRepeatTime")] 
		public CFloat SingleNpcMinRepeatTime
		{
			get => GetProperty(ref _singleNpcMinRepeatTime);
			set => SetProperty(ref _singleNpcMinRepeatTime, value);
		}

		[Ordinal(2)] 
		[RED("allNpcsMinRepeatTime")] 
		public CFloat AllNpcsMinRepeatTime
		{
			get => GetProperty(ref _allNpcsMinRepeatTime);
			set => SetProperty(ref _allNpcsMinRepeatTime, value);
		}

		[Ordinal(3)] 
		[RED("allNpcsSharingVoicesetMinRepeatTime")] 
		public CFloat AllNpcsSharingVoicesetMinRepeatTime
		{
			get => GetProperty(ref _allNpcsSharingVoicesetMinRepeatTime);
			set => SetProperty(ref _allNpcsSharingVoicesetMinRepeatTime, value);
		}

		[Ordinal(4)] 
		[RED("combatVolume")] 
		public CFloat CombatVolume
		{
			get => GetProperty(ref _combatVolume);
			set => SetProperty(ref _combatVolume, value);
		}

		public audioVoiceTriggerLimits(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
