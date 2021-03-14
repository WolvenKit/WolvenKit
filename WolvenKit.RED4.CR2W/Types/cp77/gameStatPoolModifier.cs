using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameStatPoolModifier : CVariable
	{
		private CBool _enabled;
		private CFloat _rangeBegin;
		private CFloat _rangeEnd;
		private CFloat _startDelay;
		private CFloat _valuePerSec;
		private CBool _delayOnChange;
		private CBool _usingPointValues;

		[Ordinal(0)] 
		[RED("enabled")] 
		public CBool Enabled
		{
			get
			{
				if (_enabled == null)
				{
					_enabled = (CBool) CR2WTypeManager.Create("Bool", "enabled", cr2w, this);
				}
				return _enabled;
			}
			set
			{
				if (_enabled == value)
				{
					return;
				}
				_enabled = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("rangeBegin")] 
		public CFloat RangeBegin
		{
			get
			{
				if (_rangeBegin == null)
				{
					_rangeBegin = (CFloat) CR2WTypeManager.Create("Float", "rangeBegin", cr2w, this);
				}
				return _rangeBegin;
			}
			set
			{
				if (_rangeBegin == value)
				{
					return;
				}
				_rangeBegin = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("rangeEnd")] 
		public CFloat RangeEnd
		{
			get
			{
				if (_rangeEnd == null)
				{
					_rangeEnd = (CFloat) CR2WTypeManager.Create("Float", "rangeEnd", cr2w, this);
				}
				return _rangeEnd;
			}
			set
			{
				if (_rangeEnd == value)
				{
					return;
				}
				_rangeEnd = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("startDelay")] 
		public CFloat StartDelay
		{
			get
			{
				if (_startDelay == null)
				{
					_startDelay = (CFloat) CR2WTypeManager.Create("Float", "startDelay", cr2w, this);
				}
				return _startDelay;
			}
			set
			{
				if (_startDelay == value)
				{
					return;
				}
				_startDelay = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("valuePerSec")] 
		public CFloat ValuePerSec
		{
			get
			{
				if (_valuePerSec == null)
				{
					_valuePerSec = (CFloat) CR2WTypeManager.Create("Float", "valuePerSec", cr2w, this);
				}
				return _valuePerSec;
			}
			set
			{
				if (_valuePerSec == value)
				{
					return;
				}
				_valuePerSec = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("delayOnChange")] 
		public CBool DelayOnChange
		{
			get
			{
				if (_delayOnChange == null)
				{
					_delayOnChange = (CBool) CR2WTypeManager.Create("Bool", "delayOnChange", cr2w, this);
				}
				return _delayOnChange;
			}
			set
			{
				if (_delayOnChange == value)
				{
					return;
				}
				_delayOnChange = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("usingPointValues")] 
		public CBool UsingPointValues
		{
			get
			{
				if (_usingPointValues == null)
				{
					_usingPointValues = (CBool) CR2WTypeManager.Create("Bool", "usingPointValues", cr2w, this);
				}
				return _usingPointValues;
			}
			set
			{
				if (_usingPointValues == value)
				{
					return;
				}
				_usingPointValues = value;
				PropertySet(this);
			}
		}

		public gameStatPoolModifier(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
