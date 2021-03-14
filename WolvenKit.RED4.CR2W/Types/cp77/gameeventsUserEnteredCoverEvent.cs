using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameeventsUserEnteredCoverEvent : redEvent
	{
		private CArray<WorldTransform> _actionsPoints;

		[Ordinal(0)] 
		[RED("actionsPoints")] 
		public CArray<WorldTransform> ActionsPoints
		{
			get
			{
				if (_actionsPoints == null)
				{
					_actionsPoints = (CArray<WorldTransform>) CR2WTypeManager.Create("array:WorldTransform", "actionsPoints", cr2w, this);
				}
				return _actionsPoints;
			}
			set
			{
				if (_actionsPoints == value)
				{
					return;
				}
				_actionsPoints = value;
				PropertySet(this);
			}
		}

		public gameeventsUserEnteredCoverEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
