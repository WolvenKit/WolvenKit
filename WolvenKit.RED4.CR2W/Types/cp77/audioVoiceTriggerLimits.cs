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
			get
			{
				if (_probability == null)
				{
					_probability = (CFloat) CR2WTypeManager.Create("Float", "probability", cr2w, this);
				}
				return _probability;
			}
			set
			{
				if (_probability == value)
				{
					return;
				}
				_probability = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("singleNpcMinRepeatTime")] 
		public CFloat SingleNpcMinRepeatTime
		{
			get
			{
				if (_singleNpcMinRepeatTime == null)
				{
					_singleNpcMinRepeatTime = (CFloat) CR2WTypeManager.Create("Float", "singleNpcMinRepeatTime", cr2w, this);
				}
				return _singleNpcMinRepeatTime;
			}
			set
			{
				if (_singleNpcMinRepeatTime == value)
				{
					return;
				}
				_singleNpcMinRepeatTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("allNpcsMinRepeatTime")] 
		public CFloat AllNpcsMinRepeatTime
		{
			get
			{
				if (_allNpcsMinRepeatTime == null)
				{
					_allNpcsMinRepeatTime = (CFloat) CR2WTypeManager.Create("Float", "allNpcsMinRepeatTime", cr2w, this);
				}
				return _allNpcsMinRepeatTime;
			}
			set
			{
				if (_allNpcsMinRepeatTime == value)
				{
					return;
				}
				_allNpcsMinRepeatTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("allNpcsSharingVoicesetMinRepeatTime")] 
		public CFloat AllNpcsSharingVoicesetMinRepeatTime
		{
			get
			{
				if (_allNpcsSharingVoicesetMinRepeatTime == null)
				{
					_allNpcsSharingVoicesetMinRepeatTime = (CFloat) CR2WTypeManager.Create("Float", "allNpcsSharingVoicesetMinRepeatTime", cr2w, this);
				}
				return _allNpcsSharingVoicesetMinRepeatTime;
			}
			set
			{
				if (_allNpcsSharingVoicesetMinRepeatTime == value)
				{
					return;
				}
				_allNpcsSharingVoicesetMinRepeatTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("combatVolume")] 
		public CFloat CombatVolume
		{
			get
			{
				if (_combatVolume == null)
				{
					_combatVolume = (CFloat) CR2WTypeManager.Create("Float", "combatVolume", cr2w, this);
				}
				return _combatVolume;
			}
			set
			{
				if (_combatVolume == value)
				{
					return;
				}
				_combatVolume = value;
				PropertySet(this);
			}
		}

		public audioVoiceTriggerLimits(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
