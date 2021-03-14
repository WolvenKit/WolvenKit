using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FocusClueDefinition : CVariable
	{
		private CArray<ClueRecordData> _extendedClueRecords;
		private TweakDBID _clueRecord;
		private CName _factToActivate;
		private CArray<SFactOperationData> _facts;
		private CBool _useAutoInspect;
		private CBool _isEnabled;
		private CBool _isProgressing;
		private CName _clueGroupID;
		private CBool _wasInspected;
		private CUInt32 _qDbCallbackID;
		private CEnum<EConclusionQuestState> _conclusionQuestState;

		[Ordinal(0)] 
		[RED("extendedClueRecords")] 
		public CArray<ClueRecordData> ExtendedClueRecords
		{
			get
			{
				if (_extendedClueRecords == null)
				{
					_extendedClueRecords = (CArray<ClueRecordData>) CR2WTypeManager.Create("array:ClueRecordData", "extendedClueRecords", cr2w, this);
				}
				return _extendedClueRecords;
			}
			set
			{
				if (_extendedClueRecords == value)
				{
					return;
				}
				_extendedClueRecords = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("clueRecord")] 
		public TweakDBID ClueRecord
		{
			get
			{
				if (_clueRecord == null)
				{
					_clueRecord = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "clueRecord", cr2w, this);
				}
				return _clueRecord;
			}
			set
			{
				if (_clueRecord == value)
				{
					return;
				}
				_clueRecord = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("factToActivate")] 
		public CName FactToActivate
		{
			get
			{
				if (_factToActivate == null)
				{
					_factToActivate = (CName) CR2WTypeManager.Create("CName", "factToActivate", cr2w, this);
				}
				return _factToActivate;
			}
			set
			{
				if (_factToActivate == value)
				{
					return;
				}
				_factToActivate = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("facts")] 
		public CArray<SFactOperationData> Facts
		{
			get
			{
				if (_facts == null)
				{
					_facts = (CArray<SFactOperationData>) CR2WTypeManager.Create("array:SFactOperationData", "facts", cr2w, this);
				}
				return _facts;
			}
			set
			{
				if (_facts == value)
				{
					return;
				}
				_facts = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("useAutoInspect")] 
		public CBool UseAutoInspect
		{
			get
			{
				if (_useAutoInspect == null)
				{
					_useAutoInspect = (CBool) CR2WTypeManager.Create("Bool", "useAutoInspect", cr2w, this);
				}
				return _useAutoInspect;
			}
			set
			{
				if (_useAutoInspect == value)
				{
					return;
				}
				_useAutoInspect = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get
			{
				if (_isEnabled == null)
				{
					_isEnabled = (CBool) CR2WTypeManager.Create("Bool", "isEnabled", cr2w, this);
				}
				return _isEnabled;
			}
			set
			{
				if (_isEnabled == value)
				{
					return;
				}
				_isEnabled = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("isProgressing")] 
		public CBool IsProgressing
		{
			get
			{
				if (_isProgressing == null)
				{
					_isProgressing = (CBool) CR2WTypeManager.Create("Bool", "isProgressing", cr2w, this);
				}
				return _isProgressing;
			}
			set
			{
				if (_isProgressing == value)
				{
					return;
				}
				_isProgressing = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("clueGroupID")] 
		public CName ClueGroupID
		{
			get
			{
				if (_clueGroupID == null)
				{
					_clueGroupID = (CName) CR2WTypeManager.Create("CName", "clueGroupID", cr2w, this);
				}
				return _clueGroupID;
			}
			set
			{
				if (_clueGroupID == value)
				{
					return;
				}
				_clueGroupID = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("wasInspected")] 
		public CBool WasInspected
		{
			get
			{
				if (_wasInspected == null)
				{
					_wasInspected = (CBool) CR2WTypeManager.Create("Bool", "wasInspected", cr2w, this);
				}
				return _wasInspected;
			}
			set
			{
				if (_wasInspected == value)
				{
					return;
				}
				_wasInspected = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("qDbCallbackID")] 
		public CUInt32 QDbCallbackID
		{
			get
			{
				if (_qDbCallbackID == null)
				{
					_qDbCallbackID = (CUInt32) CR2WTypeManager.Create("Uint32", "qDbCallbackID", cr2w, this);
				}
				return _qDbCallbackID;
			}
			set
			{
				if (_qDbCallbackID == value)
				{
					return;
				}
				_qDbCallbackID = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("conclusionQuestState")] 
		public CEnum<EConclusionQuestState> ConclusionQuestState
		{
			get
			{
				if (_conclusionQuestState == null)
				{
					_conclusionQuestState = (CEnum<EConclusionQuestState>) CR2WTypeManager.Create("EConclusionQuestState", "conclusionQuestState", cr2w, this);
				}
				return _conclusionQuestState;
			}
			set
			{
				if (_conclusionQuestState == value)
				{
					return;
				}
				_conclusionQuestState = value;
				PropertySet(this);
			}
		}

		public FocusClueDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
