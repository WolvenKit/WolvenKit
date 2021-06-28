using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class grsGatherAreaReplicatedInfo : CVariable
	{
		private CStatic<netPeerID> _enteredPlayerIDs;
		private CBool _hasActiveQuestListener;
		private CBool _enabled;

		[Ordinal(0)] 
		[RED("enteredPlayerIDs", 7)] 
		public CStatic<netPeerID> EnteredPlayerIDs
		{
			get => GetProperty(ref _enteredPlayerIDs);
			set => SetProperty(ref _enteredPlayerIDs, value);
		}

		[Ordinal(1)] 
		[RED("hasActiveQuestListener")] 
		public CBool HasActiveQuestListener
		{
			get => GetProperty(ref _hasActiveQuestListener);
			set => SetProperty(ref _hasActiveQuestListener, value);
		}

		[Ordinal(2)] 
		[RED("enabled")] 
		public CBool Enabled
		{
			get => GetProperty(ref _enabled);
			set => SetProperty(ref _enabled, value);
		}

		public grsGatherAreaReplicatedInfo(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
