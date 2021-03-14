using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetFactEffector : gameEffector
	{
		private CName _fact;
		private CInt32 _value;

		[Ordinal(0)] 
		[RED("fact")] 
		public CName Fact
		{
			get
			{
				if (_fact == null)
				{
					_fact = (CName) CR2WTypeManager.Create("CName", "fact", cr2w, this);
				}
				return _fact;
			}
			set
			{
				if (_fact == value)
				{
					return;
				}
				_fact = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
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

		public SetFactEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
