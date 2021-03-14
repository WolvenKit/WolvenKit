using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_FloatTimeDependentSinus : animAnimNode_FloatValue
	{
		private CFloat _min;
		private CFloat _max;
		private CFloat _frequencyFactor;
		private CFloat _phaseFactor;

		[Ordinal(11)] 
		[RED("min")] 
		public CFloat Min
		{
			get
			{
				if (_min == null)
				{
					_min = (CFloat) CR2WTypeManager.Create("Float", "min", cr2w, this);
				}
				return _min;
			}
			set
			{
				if (_min == value)
				{
					return;
				}
				_min = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("max")] 
		public CFloat Max
		{
			get
			{
				if (_max == null)
				{
					_max = (CFloat) CR2WTypeManager.Create("Float", "max", cr2w, this);
				}
				return _max;
			}
			set
			{
				if (_max == value)
				{
					return;
				}
				_max = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("frequencyFactor")] 
		public CFloat FrequencyFactor
		{
			get
			{
				if (_frequencyFactor == null)
				{
					_frequencyFactor = (CFloat) CR2WTypeManager.Create("Float", "frequencyFactor", cr2w, this);
				}
				return _frequencyFactor;
			}
			set
			{
				if (_frequencyFactor == value)
				{
					return;
				}
				_frequencyFactor = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("phaseFactor")] 
		public CFloat PhaseFactor
		{
			get
			{
				if (_phaseFactor == null)
				{
					_phaseFactor = (CFloat) CR2WTypeManager.Create("Float", "phaseFactor", cr2w, this);
				}
				return _phaseFactor;
			}
			set
			{
				if (_phaseFactor == value)
				{
					return;
				}
				_phaseFactor = value;
				PropertySet(this);
			}
		}

		public animAnimNode_FloatTimeDependentSinus(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
