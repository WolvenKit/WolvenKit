using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GetCurrentPatrolSpotActionPath : AIbehaviortaskScript
	{
		private CHandle<AIArgumentMapping> _outPathArgument;

		[Ordinal(0)] 
		[RED("outPathArgument")] 
		public CHandle<AIArgumentMapping> OutPathArgument
		{
			get
			{
				if (_outPathArgument == null)
				{
					_outPathArgument = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "outPathArgument", cr2w, this);
				}
				return _outPathArgument;
			}
			set
			{
				if (_outPathArgument == value)
				{
					return;
				}
				_outPathArgument = value;
				PropertySet(this);
			}
		}

		public GetCurrentPatrolSpotActionPath(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
