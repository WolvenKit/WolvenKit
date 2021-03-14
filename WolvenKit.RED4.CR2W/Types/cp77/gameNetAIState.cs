using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameNetAIState : CVariable
	{
		private CInt32 _value;
		private CInt32 _prevValue;
		private CFloat _time;

		[Ordinal(0)] 
		[RED("value")] 
		public CInt32 Value
		{
			get
			{
				if (_value == null)
				{
					_value = (CInt32) CR2WTypeManager.Create("Int32", "value", cr2w, this);
				}
				return _value;
			}
			set
			{
				if (_value == value)
				{
					return;
				}
				_value = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("prevValue")] 
		public CInt32 PrevValue
		{
			get
			{
				if (_prevValue == null)
				{
					_prevValue = (CInt32) CR2WTypeManager.Create("Int32", "prevValue", cr2w, this);
				}
				return _prevValue;
			}
			set
			{
				if (_prevValue == value)
				{
					return;
				}
				_prevValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("time")] 
		public CFloat Time
		{
			get
			{
				if (_time == null)
				{
					_time = (CFloat) CR2WTypeManager.Create("Float", "time", cr2w, this);
				}
				return _time;
			}
			set
			{
				if (_time == value)
				{
					return;
				}
				_time = value;
				PropertySet(this);
			}
		}

		public gameNetAIState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
