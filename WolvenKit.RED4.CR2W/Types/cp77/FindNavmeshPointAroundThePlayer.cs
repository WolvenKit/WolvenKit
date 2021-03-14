using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FindNavmeshPointAroundThePlayer : AIbehaviortaskScript
	{
		private CHandle<AIArgumentMapping> _outPositionArgument;

		[Ordinal(0)] 
		[RED("outPositionArgument")] 
		public CHandle<AIArgumentMapping> OutPositionArgument
		{
			get
			{
				if (_outPositionArgument == null)
				{
					_outPositionArgument = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "outPositionArgument", cr2w, this);
				}
				return _outPositionArgument;
			}
			set
			{
				if (_outPositionArgument == value)
				{
					return;
				}
				_outPositionArgument = value;
				PropertySet(this);
			}
		}

		public FindNavmeshPointAroundThePlayer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
