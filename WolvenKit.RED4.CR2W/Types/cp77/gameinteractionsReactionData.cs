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
			get
			{
				if (_choiceName == null)
				{
					_choiceName = (CName) CR2WTypeManager.Create("CName", "choiceName", cr2w, this);
				}
				return _choiceName;
			}
			set
			{
				if (_choiceName == value)
				{
					return;
				}
				_choiceName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("startDuration")] 
		public CFloat StartDuration
		{
			get
			{
				if (_startDuration == null)
				{
					_startDuration = (CFloat) CR2WTypeManager.Create("Float", "startDuration", cr2w, this);
				}
				return _startDuration;
			}
			set
			{
				if (_startDuration == value)
				{
					return;
				}
				_startDuration = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("endDuration")] 
		public CFloat EndDuration
		{
			get
			{
				if (_endDuration == null)
				{
					_endDuration = (CFloat) CR2WTypeManager.Create("Float", "endDuration", cr2w, this);
				}
				return _endDuration;
			}
			set
			{
				if (_endDuration == value)
				{
					return;
				}
				_endDuration = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("interactionDuration")] 
		public CFloat InteractionDuration
		{
			get
			{
				if (_interactionDuration == null)
				{
					_interactionDuration = (CFloat) CR2WTypeManager.Create("Float", "interactionDuration", cr2w, this);
				}
				return _interactionDuration;
			}
			set
			{
				if (_interactionDuration == value)
				{
					return;
				}
				_interactionDuration = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("interactionType")] 
		public CName InteractionType
		{
			get
			{
				if (_interactionType == null)
				{
					_interactionType = (CName) CR2WTypeManager.Create("CName", "interactionType", cr2w, this);
				}
				return _interactionType;
			}
			set
			{
				if (_interactionType == value)
				{
					return;
				}
				_interactionType = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("requiredEquips")] 
		public CArray<gameEquipParam> RequiredEquips
		{
			get
			{
				if (_requiredEquips == null)
				{
					_requiredEquips = (CArray<gameEquipParam>) CR2WTypeManager.Create("array:gameEquipParam", "requiredEquips", cr2w, this);
				}
				return _requiredEquips;
			}
			set
			{
				if (_requiredEquips == value)
				{
					return;
				}
				_requiredEquips = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("interactionPoint")] 
		public Transform InteractionPoint
		{
			get
			{
				if (_interactionPoint == null)
				{
					_interactionPoint = (Transform) CR2WTypeManager.Create("Transform", "interactionPoint", cr2w, this);
				}
				return _interactionPoint;
			}
			set
			{
				if (_interactionPoint == value)
				{
					return;
				}
				_interactionPoint = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("useIK")] 
		public CBool UseIK
		{
			get
			{
				if (_useIK == null)
				{
					_useIK = (CBool) CR2WTypeManager.Create("Bool", "useIK", cr2w, this);
				}
				return _useIK;
			}
			set
			{
				if (_useIK == value)
				{
					return;
				}
				_useIK = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("IKPoint")] 
		public Vector4 IKPoint
		{
			get
			{
				if (_iKPoint == null)
				{
					_iKPoint = (Vector4) CR2WTypeManager.Create("Vector4", "IKPoint", cr2w, this);
				}
				return _iKPoint;
			}
			set
			{
				if (_iKPoint == value)
				{
					return;
				}
				_iKPoint = value;
				PropertySet(this);
			}
		}

		public gameinteractionsReactionData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
