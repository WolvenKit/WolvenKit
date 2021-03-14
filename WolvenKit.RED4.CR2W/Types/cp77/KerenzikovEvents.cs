using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class KerenzikovEvents : TimeDilationEventsTransitions
	{
		private CHandle<gameStatModifierData> _allowMovementModifier;

		[Ordinal(0)] 
		[RED("allowMovementModifier")] 
		public CHandle<gameStatModifierData> AllowMovementModifier
		{
			get
			{
				if (_allowMovementModifier == null)
				{
					_allowMovementModifier = (CHandle<gameStatModifierData>) CR2WTypeManager.Create("handle:gameStatModifierData", "allowMovementModifier", cr2w, this);
				}
				return _allowMovementModifier;
			}
			set
			{
				if (_allowMovementModifier == value)
				{
					return;
				}
				_allowMovementModifier = value;
				PropertySet(this);
			}
		}

		public KerenzikovEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
