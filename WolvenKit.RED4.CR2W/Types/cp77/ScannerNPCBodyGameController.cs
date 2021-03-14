using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScannerNPCBodyGameController : BaseChunkGameController
	{
		private inkTextWidgetReference _factionText;
		private inkWidgetReference _dataBaseWidgetHolder;
		private CUInt32 _factionCallbackID;
		private CUInt32 _rarityCallbackID;
		private CBool _isValidFaction;

		[Ordinal(5)] 
		[RED("factionText")] 
		public inkTextWidgetReference FactionText
		{
			get
			{
				if (_factionText == null)
				{
					_factionText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "factionText", cr2w, this);
				}
				return _factionText;
			}
			set
			{
				if (_factionText == value)
				{
					return;
				}
				_factionText = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("dataBaseWidgetHolder")] 
		public inkWidgetReference DataBaseWidgetHolder
		{
			get
			{
				if (_dataBaseWidgetHolder == null)
				{
					_dataBaseWidgetHolder = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "dataBaseWidgetHolder", cr2w, this);
				}
				return _dataBaseWidgetHolder;
			}
			set
			{
				if (_dataBaseWidgetHolder == value)
				{
					return;
				}
				_dataBaseWidgetHolder = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("factionCallbackID")] 
		public CUInt32 FactionCallbackID
		{
			get
			{
				if (_factionCallbackID == null)
				{
					_factionCallbackID = (CUInt32) CR2WTypeManager.Create("Uint32", "factionCallbackID", cr2w, this);
				}
				return _factionCallbackID;
			}
			set
			{
				if (_factionCallbackID == value)
				{
					return;
				}
				_factionCallbackID = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("rarityCallbackID")] 
		public CUInt32 RarityCallbackID
		{
			get
			{
				if (_rarityCallbackID == null)
				{
					_rarityCallbackID = (CUInt32) CR2WTypeManager.Create("Uint32", "rarityCallbackID", cr2w, this);
				}
				return _rarityCallbackID;
			}
			set
			{
				if (_rarityCallbackID == value)
				{
					return;
				}
				_rarityCallbackID = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("isValidFaction")] 
		public CBool IsValidFaction
		{
			get
			{
				if (_isValidFaction == null)
				{
					_isValidFaction = (CBool) CR2WTypeManager.Create("Bool", "isValidFaction", cr2w, this);
				}
				return _isValidFaction;
			}
			set
			{
				if (_isValidFaction == value)
				{
					return;
				}
				_isValidFaction = value;
				PropertySet(this);
			}
		}

		public ScannerNPCBodyGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
