using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HackPlayerEvent : redEvent
	{
		private entEntityID _netrunnerID;
		private entEntityID _targetID;
		private wCHandle<gamedataObjectAction_Record> _objectRecord;
		private CBool _showDirectionalIndicator;
		private CBool _revealPositionAction;

		[Ordinal(0)] 
		[RED("netrunnerID")] 
		public entEntityID NetrunnerID
		{
			get => GetProperty(ref _netrunnerID);
			set => SetProperty(ref _netrunnerID, value);
		}

		[Ordinal(1)] 
		[RED("targetID")] 
		public entEntityID TargetID
		{
			get => GetProperty(ref _targetID);
			set => SetProperty(ref _targetID, value);
		}

		[Ordinal(2)] 
		[RED("objectRecord")] 
		public wCHandle<gamedataObjectAction_Record> ObjectRecord
		{
			get => GetProperty(ref _objectRecord);
			set => SetProperty(ref _objectRecord, value);
		}

		[Ordinal(3)] 
		[RED("showDirectionalIndicator")] 
		public CBool ShowDirectionalIndicator
		{
			get => GetProperty(ref _showDirectionalIndicator);
			set => SetProperty(ref _showDirectionalIndicator, value);
		}

		[Ordinal(4)] 
		[RED("revealPositionAction")] 
		public CBool RevealPositionAction
		{
			get => GetProperty(ref _revealPositionAction);
			set => SetProperty(ref _revealPositionAction, value);
		}

		public HackPlayerEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
