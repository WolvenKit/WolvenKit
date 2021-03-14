using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ToggleFactEffector : gameEffector
	{
		private CName _fact;
		private CInt32 _valueOn;
		private CInt32 _valueOff;

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
		[RED("valueOn")] 
		public CInt32 ValueOn
		{
			get
			{
				if (_valueOn == null)
				{
					_valueOn = (CInt32) CR2WTypeManager.Create("Int32", "valueOn", cr2w, this);
				}
				return _valueOn;
			}
			set
			{
				if (_valueOn == value)
				{
					return;
				}
				_valueOn = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("valueOff")] 
		public CInt32 ValueOff
		{
			get
			{
				if (_valueOff == null)
				{
					_valueOff = (CInt32) CR2WTypeManager.Create("Int32", "valueOff", cr2w, this);
				}
				return _valueOff;
			}
			set
			{
				if (_valueOff == value)
				{
					return;
				}
				_valueOff = value;
				PropertySet(this);
			}
		}

		public ToggleFactEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
