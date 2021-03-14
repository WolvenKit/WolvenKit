using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SingleWieldEvents : UpperBodyEventsTransition
	{
		private CBool _hasInstantEquipHackBeenApplied;

		[Ordinal(6)] 
		[RED("hasInstantEquipHackBeenApplied")] 
		public CBool HasInstantEquipHackBeenApplied
		{
			get
			{
				if (_hasInstantEquipHackBeenApplied == null)
				{
					_hasInstantEquipHackBeenApplied = (CBool) CR2WTypeManager.Create("Bool", "hasInstantEquipHackBeenApplied", cr2w, this);
				}
				return _hasInstantEquipHackBeenApplied;
			}
			set
			{
				if (_hasInstantEquipHackBeenApplied == value)
				{
					return;
				}
				_hasInstantEquipHackBeenApplied = value;
				PropertySet(this);
			}
		}

		public SingleWieldEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
