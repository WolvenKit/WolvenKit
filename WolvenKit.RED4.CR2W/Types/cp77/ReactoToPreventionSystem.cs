using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ReactoToPreventionSystem : redEvent
	{
		private CBool _wakeUp;

		[Ordinal(0)] 
		[RED("wakeUp")] 
		public CBool WakeUp
		{
			get
			{
				if (_wakeUp == null)
				{
					_wakeUp = (CBool) CR2WTypeManager.Create("Bool", "wakeUp", cr2w, this);
				}
				return _wakeUp;
			}
			set
			{
				if (_wakeUp == value)
				{
					return;
				}
				_wakeUp = value;
				PropertySet(this);
			}
		}

		public ReactoToPreventionSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
