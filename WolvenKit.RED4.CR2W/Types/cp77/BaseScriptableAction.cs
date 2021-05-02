using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BaseScriptableAction : gamedeviceAction
	{
		private entEntityID _requesterID;
		private wCHandle<gameObject> _executor;
		private TweakDBID _objectActionID;
		private wCHandle<gamedataObjectAction_Record> _objectActionRecord;
		private TweakDBID _inkWidgetID;
		private gameinteractionsChoice _interactionChoice;
		private CName _interactionLayer;
		private CBool _isActionRPGCheckDissabled;

		[Ordinal(3)] 
		[RED("requesterID")] 
		public entEntityID RequesterID
		{
			get => GetProperty(ref _requesterID);
			set => SetProperty(ref _requesterID, value);
		}

		[Ordinal(4)] 
		[RED("executor")] 
		public wCHandle<gameObject> Executor
		{
			get => GetProperty(ref _executor);
			set => SetProperty(ref _executor, value);
		}

		[Ordinal(5)] 
		[RED("objectActionID")] 
		public TweakDBID ObjectActionID
		{
			get => GetProperty(ref _objectActionID);
			set => SetProperty(ref _objectActionID, value);
		}

		[Ordinal(6)] 
		[RED("objectActionRecord")] 
		public wCHandle<gamedataObjectAction_Record> ObjectActionRecord
		{
			get => GetProperty(ref _objectActionRecord);
			set => SetProperty(ref _objectActionRecord, value);
		}

		[Ordinal(7)] 
		[RED("inkWidgetID")] 
		public TweakDBID InkWidgetID
		{
			get => GetProperty(ref _inkWidgetID);
			set => SetProperty(ref _inkWidgetID, value);
		}

		[Ordinal(8)] 
		[RED("interactionChoice")] 
		public gameinteractionsChoice InteractionChoice
		{
			get => GetProperty(ref _interactionChoice);
			set => SetProperty(ref _interactionChoice, value);
		}

		[Ordinal(9)] 
		[RED("interactionLayer")] 
		public CName InteractionLayer
		{
			get => GetProperty(ref _interactionLayer);
			set => SetProperty(ref _interactionLayer, value);
		}

		[Ordinal(10)] 
		[RED("isActionRPGCheckDissabled")] 
		public CBool IsActionRPGCheckDissabled
		{
			get => GetProperty(ref _isActionRPGCheckDissabled);
			set => SetProperty(ref _isActionRPGCheckDissabled, value);
		}

		public BaseScriptableAction(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
