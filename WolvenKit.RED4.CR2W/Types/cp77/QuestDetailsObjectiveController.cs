using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuestDetailsObjectiveController : inkWidgetLogicController
	{
		private inkTextWidgetReference _objectiveName;
		private inkWidgetReference _trackingMarker;
		private inkWidgetReference _root;
		private wCHandle<gameJournalQuestObjective> _objective;
		private CBool _hovered;

		[Ordinal(1)] 
		[RED("objectiveName")] 
		public inkTextWidgetReference ObjectiveName
		{
			get => GetProperty(ref _objectiveName);
			set => SetProperty(ref _objectiveName, value);
		}

		[Ordinal(2)] 
		[RED("trackingMarker")] 
		public inkWidgetReference TrackingMarker
		{
			get => GetProperty(ref _trackingMarker);
			set => SetProperty(ref _trackingMarker, value);
		}

		[Ordinal(3)] 
		[RED("root")] 
		public inkWidgetReference Root
		{
			get => GetProperty(ref _root);
			set => SetProperty(ref _root, value);
		}

		[Ordinal(4)] 
		[RED("objective")] 
		public wCHandle<gameJournalQuestObjective> Objective
		{
			get => GetProperty(ref _objective);
			set => SetProperty(ref _objective, value);
		}

		[Ordinal(5)] 
		[RED("hovered")] 
		public CBool Hovered
		{
			get => GetProperty(ref _hovered);
			set => SetProperty(ref _hovered, value);
		}

		public QuestDetailsObjectiveController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
