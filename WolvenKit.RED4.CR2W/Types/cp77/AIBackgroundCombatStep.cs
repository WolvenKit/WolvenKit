using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIBackgroundCombatStep : CVariable
	{
		private CFloat _timeMin;
		private CFloat _timeMax;
		private CEnum<EAIBackgroundCombatStep> _type;
		private gameEntityReference _argument;
		private CEnum<AICoverExposureMethod> _exposureMethod;

		[Ordinal(0)] 
		[RED("timeMin")] 
		public CFloat TimeMin
		{
			get
			{
				if (_timeMin == null)
				{
					_timeMin = (CFloat) CR2WTypeManager.Create("Float", "timeMin", cr2w, this);
				}
				return _timeMin;
			}
			set
			{
				if (_timeMin == value)
				{
					return;
				}
				_timeMin = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("timeMax")] 
		public CFloat TimeMax
		{
			get
			{
				if (_timeMax == null)
				{
					_timeMax = (CFloat) CR2WTypeManager.Create("Float", "timeMax", cr2w, this);
				}
				return _timeMax;
			}
			set
			{
				if (_timeMax == value)
				{
					return;
				}
				_timeMax = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("type")] 
		public CEnum<EAIBackgroundCombatStep> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CEnum<EAIBackgroundCombatStep>) CR2WTypeManager.Create("EAIBackgroundCombatStep", "type", cr2w, this);
				}
				return _type;
			}
			set
			{
				if (_type == value)
				{
					return;
				}
				_type = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("argument")] 
		public gameEntityReference Argument
		{
			get
			{
				if (_argument == null)
				{
					_argument = (gameEntityReference) CR2WTypeManager.Create("gameEntityReference", "argument", cr2w, this);
				}
				return _argument;
			}
			set
			{
				if (_argument == value)
				{
					return;
				}
				_argument = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("exposureMethod")] 
		public CEnum<AICoverExposureMethod> ExposureMethod
		{
			get
			{
				if (_exposureMethod == null)
				{
					_exposureMethod = (CEnum<AICoverExposureMethod>) CR2WTypeManager.Create("AICoverExposureMethod", "exposureMethod", cr2w, this);
				}
				return _exposureMethod;
			}
			set
			{
				if (_exposureMethod == value)
				{
					return;
				}
				_exposureMethod = value;
				PropertySet(this);
			}
		}

		public AIBackgroundCombatStep(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
