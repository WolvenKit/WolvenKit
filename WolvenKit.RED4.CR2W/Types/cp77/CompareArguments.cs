using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CompareArguments : AIbehaviorconditionScript
	{
		private CName _var1;
		private CName _var2;

		[Ordinal(0)] 
		[RED("var1")] 
		public CName Var1
		{
			get
			{
				if (_var1 == null)
				{
					_var1 = (CName) CR2WTypeManager.Create("CName", "var1", cr2w, this);
				}
				return _var1;
			}
			set
			{
				if (_var1 == value)
				{
					return;
				}
				_var1 = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("var2")] 
		public CName Var2
		{
			get
			{
				if (_var2 == null)
				{
					_var2 = (CName) CR2WTypeManager.Create("CName", "var2", cr2w, this);
				}
				return _var2;
			}
			set
			{
				if (_var2 == value)
				{
					return;
				}
				_var2 = value;
				PropertySet(this);
			}
		}

		public CompareArguments(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
