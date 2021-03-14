using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DisableBraindanceActions : redEvent
	{
		private SBraindanceInputMask _actionMask;

		[Ordinal(0)] 
		[RED("actionMask")] 
		public SBraindanceInputMask ActionMask
		{
			get
			{
				if (_actionMask == null)
				{
					_actionMask = (SBraindanceInputMask) CR2WTypeManager.Create("SBraindanceInputMask", "actionMask", cr2w, this);
				}
				return _actionMask;
			}
			set
			{
				if (_actionMask == value)
				{
					return;
				}
				_actionMask = value;
				PropertySet(this);
			}
		}

		public DisableBraindanceActions(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
