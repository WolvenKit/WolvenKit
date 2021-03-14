using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorMonitorTaskNodeDefinition : AIbehaviorTaskNodeDefinition
	{
		private CFloat _timeout;

		[Ordinal(2)] 
		[RED("timeout")] 
		public CFloat Timeout
		{
			get
			{
				if (_timeout == null)
				{
					_timeout = (CFloat) CR2WTypeManager.Create("Float", "timeout", cr2w, this);
				}
				return _timeout;
			}
			set
			{
				if (_timeout == value)
				{
					return;
				}
				_timeout = value;
				PropertySet(this);
			}
		}

		public AIbehaviorMonitorTaskNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
