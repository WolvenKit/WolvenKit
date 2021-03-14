using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CParticleEventGenerator : IParticleEvent
	{
		private CEnum<EParticleEventType> _evtType;
		private CFloat _frequency;
		private CFloat _probability;

		[Ordinal(4)] 
		[RED("evtType")] 
		public CEnum<EParticleEventType> EvtType
		{
			get
			{
				if (_evtType == null)
				{
					_evtType = (CEnum<EParticleEventType>) CR2WTypeManager.Create("EParticleEventType", "evtType", cr2w, this);
				}
				return _evtType;
			}
			set
			{
				if (_evtType == value)
				{
					return;
				}
				_evtType = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("frequency")] 
		public CFloat Frequency
		{
			get
			{
				if (_frequency == null)
				{
					_frequency = (CFloat) CR2WTypeManager.Create("Float", "frequency", cr2w, this);
				}
				return _frequency;
			}
			set
			{
				if (_frequency == value)
				{
					return;
				}
				_frequency = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
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

		public CParticleEventGenerator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
