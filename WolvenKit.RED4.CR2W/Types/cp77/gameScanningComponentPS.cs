using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameScanningComponentPS : gameComponentPS
	{
		private CEnum<gameScanningState> _scanningState;
		private CFloat _pctScanned;
		private CBool _isBlocked;
		private CArray<CHandle<CluePSData>> _storedClues;
		private CBool _isScanningDisabled;
		private CBool _isDecriptionEnabled;
		private CHandle<ObjectScanningDescription> _objectDescriptionOverride;

		[Ordinal(0)] 
		[RED("scanningState")] 
		public CEnum<gameScanningState> ScanningState
		{
			get
			{
				if (_scanningState == null)
				{
					_scanningState = (CEnum<gameScanningState>) CR2WTypeManager.Create("gameScanningState", "scanningState", cr2w, this);
				}
				return _scanningState;
			}
			set
			{
				if (_scanningState == value)
				{
					return;
				}
				_scanningState = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("pctScanned")] 
		public CFloat PctScanned
		{
			get
			{
				if (_pctScanned == null)
				{
					_pctScanned = (CFloat) CR2WTypeManager.Create("Float", "pctScanned", cr2w, this);
				}
				return _pctScanned;
			}
			set
			{
				if (_pctScanned == value)
				{
					return;
				}
				_pctScanned = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("isBlocked")] 
		public CBool IsBlocked
		{
			get
			{
				if (_isBlocked == null)
				{
					_isBlocked = (CBool) CR2WTypeManager.Create("Bool", "isBlocked", cr2w, this);
				}
				return _isBlocked;
			}
			set
			{
				if (_isBlocked == value)
				{
					return;
				}
				_isBlocked = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("storedClues")] 
		public CArray<CHandle<CluePSData>> StoredClues
		{
			get
			{
				if (_storedClues == null)
				{
					_storedClues = (CArray<CHandle<CluePSData>>) CR2WTypeManager.Create("array:handle:CluePSData", "storedClues", cr2w, this);
				}
				return _storedClues;
			}
			set
			{
				if (_storedClues == value)
				{
					return;
				}
				_storedClues = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("isScanningDisabled")] 
		public CBool IsScanningDisabled
		{
			get
			{
				if (_isScanningDisabled == null)
				{
					_isScanningDisabled = (CBool) CR2WTypeManager.Create("Bool", "isScanningDisabled", cr2w, this);
				}
				return _isScanningDisabled;
			}
			set
			{
				if (_isScanningDisabled == value)
				{
					return;
				}
				_isScanningDisabled = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("isDecriptionEnabled")] 
		public CBool IsDecriptionEnabled
		{
			get
			{
				if (_isDecriptionEnabled == null)
				{
					_isDecriptionEnabled = (CBool) CR2WTypeManager.Create("Bool", "isDecriptionEnabled", cr2w, this);
				}
				return _isDecriptionEnabled;
			}
			set
			{
				if (_isDecriptionEnabled == value)
				{
					return;
				}
				_isDecriptionEnabled = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("objectDescriptionOverride")] 
		public CHandle<ObjectScanningDescription> ObjectDescriptionOverride
		{
			get
			{
				if (_objectDescriptionOverride == null)
				{
					_objectDescriptionOverride = (CHandle<ObjectScanningDescription>) CR2WTypeManager.Create("handle:ObjectScanningDescription", "objectDescriptionOverride", cr2w, this);
				}
				return _objectDescriptionOverride;
			}
			set
			{
				if (_objectDescriptionOverride == value)
				{
					return;
				}
				_objectDescriptionOverride = value;
				PropertySet(this);
			}
		}

		public gameScanningComponentPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
