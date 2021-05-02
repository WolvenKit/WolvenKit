using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameSetAsQuestImportantEvent : redEvent
	{
		private CBool _isImportant;
		private CBool _propagateToSlaves;

		[Ordinal(0)] 
		[RED("isImportant")] 
		public CBool IsImportant
		{
			get => GetProperty(ref _isImportant);
			set => SetProperty(ref _isImportant, value);
		}

		[Ordinal(1)] 
		[RED("propagateToSlaves")] 
		public CBool PropagateToSlaves
		{
			get => GetProperty(ref _propagateToSlaves);
			set => SetProperty(ref _propagateToSlaves, value);
		}

		public gameSetAsQuestImportantEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
