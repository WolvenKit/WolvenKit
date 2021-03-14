using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScannerQuestCluesGameController : BaseChunkGameController
	{
		private inkCompoundWidgetReference _scannerQuestPanel;
		private CUInt32 _questCluesCallbackID;
		private CUInt32 _scannerDataCallbackID;
		private CBool _isValidQuestClues;
		private scannerDataStructure _scannerData;
		private CBool _hasValidScannables;
		private CArray<wCHandle<ScannerQuestClue>> _clues;

		[Ordinal(5)] 
		[RED("ScannerQuestPanel")] 
		public inkCompoundWidgetReference ScannerQuestPanel
		{
			get
			{
				if (_scannerQuestPanel == null)
				{
					_scannerQuestPanel = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "ScannerQuestPanel", cr2w, this);
				}
				return _scannerQuestPanel;
			}
			set
			{
				if (_scannerQuestPanel == value)
				{
					return;
				}
				_scannerQuestPanel = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("questCluesCallbackID")] 
		public CUInt32 QuestCluesCallbackID
		{
			get
			{
				if (_questCluesCallbackID == null)
				{
					_questCluesCallbackID = (CUInt32) CR2WTypeManager.Create("Uint32", "questCluesCallbackID", cr2w, this);
				}
				return _questCluesCallbackID;
			}
			set
			{
				if (_questCluesCallbackID == value)
				{
					return;
				}
				_questCluesCallbackID = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("scannerDataCallbackID")] 
		public CUInt32 ScannerDataCallbackID
		{
			get
			{
				if (_scannerDataCallbackID == null)
				{
					_scannerDataCallbackID = (CUInt32) CR2WTypeManager.Create("Uint32", "scannerDataCallbackID", cr2w, this);
				}
				return _scannerDataCallbackID;
			}
			set
			{
				if (_scannerDataCallbackID == value)
				{
					return;
				}
				_scannerDataCallbackID = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("isValidQuestClues")] 
		public CBool IsValidQuestClues
		{
			get
			{
				if (_isValidQuestClues == null)
				{
					_isValidQuestClues = (CBool) CR2WTypeManager.Create("Bool", "isValidQuestClues", cr2w, this);
				}
				return _isValidQuestClues;
			}
			set
			{
				if (_isValidQuestClues == value)
				{
					return;
				}
				_isValidQuestClues = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("ScannerData")] 
		public scannerDataStructure ScannerData
		{
			get
			{
				if (_scannerData == null)
				{
					_scannerData = (scannerDataStructure) CR2WTypeManager.Create("scannerDataStructure", "ScannerData", cr2w, this);
				}
				return _scannerData;
			}
			set
			{
				if (_scannerData == value)
				{
					return;
				}
				_scannerData = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("hasValidScannables")] 
		public CBool HasValidScannables
		{
			get
			{
				if (_hasValidScannables == null)
				{
					_hasValidScannables = (CBool) CR2WTypeManager.Create("Bool", "hasValidScannables", cr2w, this);
				}
				return _hasValidScannables;
			}
			set
			{
				if (_hasValidScannables == value)
				{
					return;
				}
				_hasValidScannables = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("Clues")] 
		public CArray<wCHandle<ScannerQuestClue>> Clues
		{
			get
			{
				if (_clues == null)
				{
					_clues = (CArray<wCHandle<ScannerQuestClue>>) CR2WTypeManager.Create("array:whandle:ScannerQuestClue", "Clues", cr2w, this);
				}
				return _clues;
			}
			set
			{
				if (_clues == value)
				{
					return;
				}
				_clues = value;
				PropertySet(this);
			}
		}

		public ScannerQuestCluesGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
