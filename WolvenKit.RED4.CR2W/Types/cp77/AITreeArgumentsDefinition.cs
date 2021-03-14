using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AITreeArgumentsDefinition : CVariable
	{
		private CArray<CHandle<AIArgumentDefinition>> _args;

		[Ordinal(0)] 
		[RED("args")] 
		public CArray<CHandle<AIArgumentDefinition>> Args
		{
			get
			{
				if (_args == null)
				{
					_args = (CArray<CHandle<AIArgumentDefinition>>) CR2WTypeManager.Create("array:handle:AIArgumentDefinition", "args", cr2w, this);
				}
				return _args;
			}
			set
			{
				if (_args == value)
				{
					return;
				}
				_args = value;
				PropertySet(this);
			}
		}

		public AITreeArgumentsDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
