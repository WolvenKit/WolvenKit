using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetRandomIntArgument : AIRandomTasks
	{
		private CInt32 _maxValue;
		private CInt32 _minValue;
		private CName _argumentName;

		[Ordinal(0)] 
		[RED("MaxValue")] 
		public CInt32 MaxValue
		{
			get
			{
				if (_maxValue == null)
				{
					_maxValue = (CInt32) CR2WTypeManager.Create("Int32", "MaxValue", cr2w, this);
				}
				return _maxValue;
			}
			set
			{
				if (_maxValue == value)
				{
					return;
				}
				_maxValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("MinValue")] 
		public CInt32 MinValue
		{
			get
			{
				if (_minValue == null)
				{
					_minValue = (CInt32) CR2WTypeManager.Create("Int32", "MinValue", cr2w, this);
				}
				return _minValue;
			}
			set
			{
				if (_minValue == value)
				{
					return;
				}
				_minValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("ArgumentName")] 
		public CName ArgumentName
		{
			get
			{
				if (_argumentName == null)
				{
					_argumentName = (CName) CR2WTypeManager.Create("CName", "ArgumentName", cr2w, this);
				}
				return _argumentName;
			}
			set
			{
				if (_argumentName == value)
				{
					return;
				}
				_argumentName = value;
				PropertySet(this);
			}
		}

		public SetRandomIntArgument(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
