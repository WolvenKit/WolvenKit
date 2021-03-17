using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsReactionData : IScriptable
	{
		private CName _choiceName;
		private CFloat _startDuration;
		private CFloat _endDuration;
		private CFloat _interactionDuration;
		private CName _interactionType;
		private CArray<gameEquipParam> _requiredEquips;
		private Transform _interactionPoint;
		private CBool _useIK;
		private Vector4 _iKPoint;

		[Ordinal(0)] 
		[RED("choiceName")] 
		public CName ChoiceName
		{
			get => GetProperty(ref _choiceName);
			set => SetProperty(ref _choiceName, value);
		}

		[Ordinal(1)] 
		[RED("startDuration")] 
		public CFloat StartDuration
		{
			get => GetProperty(ref _startDuration);
			set => SetProperty(ref _startDuration, value);
		}

		[Ordinal(2)] 
		[RED("endDuration")] 
		public CFloat EndDuration
		{
			get => GetProperty(ref _endDuration);
			set => SetProperty(ref _endDuration, value);
		}

		[Ordinal(3)] 
		[RED("interactionDuration")] 
		public CFloat InteractionDuration
		{
			get => GetProperty(ref _interactionDuration);
			set => SetProperty(ref _interactionDuration, value);
		}

		[Ordinal(4)] 
		[RED("interactionType")] 
		public CName InteractionType
		{
			get => GetProperty(ref _interactionType);
			set => SetProperty(ref _interactionType, value);
		}

		[Ordinal(5)] 
		[RED("requiredEquips")] 
		public CArray<gameEquipParam> RequiredEquips
		{
			get => GetProperty(ref _requiredEquips);
			set => SetProperty(ref _requiredEquips, value);
		}

		[Ordinal(6)] 
		[RED("interactionPoint")] 
		public Transform InteractionPoint
		{
			get => GetProperty(ref _interactionPoint);
			set => SetProperty(ref _interactionPoint, value);
		}

		[Ordinal(7)] 
		[RED("useIK")] 
		public CBool UseIK
		{
			get => GetProperty(ref _useIK);
			set => SetProperty(ref _useIK, value);
		}

		[Ordinal(8)] 
		[RED("IKPoint")] 
		public Vector4 IKPoint
		{
			get => GetProperty(ref _iKPoint);
			set => SetProperty(ref _iKPoint, value);
		}

		public gameinteractionsReactionData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
