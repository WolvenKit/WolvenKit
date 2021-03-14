using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetBooleanArgumentWhenActive : AIbehaviortaskScript
	{
		private CName _booleanArgument;

		[Ordinal(0)] 
		[RED("booleanArgument")] 
		public CName BooleanArgument
		{
			get
			{
				if (_booleanArgument == null)
				{
					_booleanArgument = (CName) CR2WTypeManager.Create("CName", "booleanArgument", cr2w, this);
				}
				return _booleanArgument;
			}
			set
			{
				if (_booleanArgument == value)
				{
					return;
				}
				_booleanArgument = value;
				PropertySet(this);
			}
		}

		public SetBooleanArgumentWhenActive(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
