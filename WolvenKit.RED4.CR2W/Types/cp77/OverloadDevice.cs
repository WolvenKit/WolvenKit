using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class OverloadDevice : ActionBool
	{
		private CFloat _killDelay;

		[Ordinal(25)] 
		[RED("killDelay")] 
		public CFloat KillDelay
		{
			get
			{
				if (_killDelay == null)
				{
					_killDelay = (CFloat) CR2WTypeManager.Create("Float", "killDelay", cr2w, this);
				}
				return _killDelay;
			}
			set
			{
				if (_killDelay == value)
				{
					return;
				}
				_killDelay = value;
				PropertySet(this);
			}
		}

		public OverloadDevice(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
