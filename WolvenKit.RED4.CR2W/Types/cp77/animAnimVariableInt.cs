using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimVariableInt : animAnimVariable
	{
		private CInt32 _value;
		private CInt32 _default;
		private CInt32 _min;
		private CInt32 _max;

		[Ordinal(2)] 
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

		[Ordinal(3)] 
		[RED("default")] 
		public CInt32 Default
		{
			get
			{
				if (_default == null)
				{
					_default = (CInt32) CR2WTypeManager.Create("Int32", "default", cr2w, this);
				}
				return _default;
			}
			set
			{
				if (_default == value)
				{
					return;
				}
				_default = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("min")] 
		public CInt32 Min
		{
			get
			{
				if (_min == null)
				{
					_min = (CInt32) CR2WTypeManager.Create("Int32", "min", cr2w, this);
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

		[Ordinal(5)] 
		[RED("max")] 
		public CInt32 Max
		{
			get
			{
				if (_max == null)
				{
					_max = (CInt32) CR2WTypeManager.Create("Int32", "max", cr2w, this);
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

		public animAnimVariableInt(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
