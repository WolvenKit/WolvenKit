using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIPatrolCommandPrologue : AICommandHandlerBase
	{
		private CHandle<AIArgumentMapping> _outPatrolPath;

		[Ordinal(1)] 
		[RED("outPatrolPath")] 
		public CHandle<AIArgumentMapping> OutPatrolPath
		{
			get
			{
				if (_outPatrolPath == null)
				{
					_outPatrolPath = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "outPatrolPath", cr2w, this);
				}
				return _outPatrolPath;
			}
			set
			{
				if (_outPatrolPath == value)
				{
					return;
				}
				_outPatrolPath = value;
				PropertySet(this);
			}
		}

		public AIPatrolCommandPrologue(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
