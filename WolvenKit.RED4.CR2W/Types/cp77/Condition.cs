using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Condition : CVariable
	{
		private CBool _passed;
		private CString _description;

		[Ordinal(0)] 
		[RED("passed")] 
		public CBool Passed
		{
			get
			{
				if (_passed == null)
				{
					_passed = (CBool) CR2WTypeManager.Create("Bool", "passed", cr2w, this);
				}
				return _passed;
			}
			set
			{
				if (_passed == value)
				{
					return;
				}
				_passed = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("description")] 
		public CString Description
		{
			get
			{
				if (_description == null)
				{
					_description = (CString) CR2WTypeManager.Create("String", "description", cr2w, this);
				}
				return _description;
			}
			set
			{
				if (_description == value)
				{
					return;
				}
				_description = value;
				PropertySet(this);
			}
		}

		public Condition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
