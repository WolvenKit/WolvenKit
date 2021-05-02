using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuestStopFollowingTarget : ActionBool
	{
		private entEntityID _targetEntityID;

		[Ordinal(25)] 
		[RED("targetEntityID")] 
		public entEntityID TargetEntityID
		{
			get => GetProperty(ref _targetEntityID);
			set => SetProperty(ref _targetEntityID, value);
		}

		public QuestStopFollowingTarget(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
