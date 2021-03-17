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
			get => GetProperty(ref _actionsPoints);
			set => SetProperty(ref _actionsPoints, value);
		}

		public gameeventsUserEnteredCoverEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
