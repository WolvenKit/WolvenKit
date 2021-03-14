using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CheckArguments : AIbehaviorconditionScript
	{
		private CName _argumentVar;

		[Ordinal(0)] 
		[RED("argumentVar")] 
		public CName ArgumentVar
		{
			get
			{
				if (_argumentVar == null)
				{
					_argumentVar = (CName) CR2WTypeManager.Create("CName", "argumentVar", cr2w, this);
				}
				return _argumentVar;
			}
			set
			{
				if (_argumentVar == value)
				{
					return;
				}
				_argumentVar = value;
				PropertySet(this);
			}
		}

		public CheckArguments(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
