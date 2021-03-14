using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AITreeNodeRepeatDefinition : AICTreeNodeDecoratorDefinition
	{
		private LibTreeDefInt32 _limit;

		[Ordinal(1)] 
		[RED("limit")] 
		public LibTreeDefInt32 Limit
		{
			get
			{
				if (_limit == null)
				{
					_limit = (LibTreeDefInt32) CR2WTypeManager.Create("LibTreeDefInt32", "limit", cr2w, this);
				}
				return _limit;
			}
			set
			{
				if (_limit == value)
				{
					return;
				}
				_limit = value;
				PropertySet(this);
			}
		}

		public AITreeNodeRepeatDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
