using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LinkedFocusClueData : CVariable
	{
		private CName _clueGroupID;
		private entEntityID _ownerID;
		private CInt32 _clueIndex;
		private TweakDBID _clueRecord;
		private CArray<ClueRecordData> _extendedClueRecords;
		private CBool _isScanned;
		private CBool _wasInspected;
		private CBool _isEnabled;
		private PSOwnerData _psData;

		[Ordinal(0)] 
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

		[Ordinal(1)] 
		[RED("ownerID")] 
		public entEntityID OwnerID
		{
			get
			{
				if (_ownerID == null)
				{
					_ownerID = (entEntityID) CR2WTypeManager.Create("entEntityID", "ownerID", cr2w, this);
				}
				return _ownerID;
			}
			set
			{
				if (_ownerID == value)
				{
					return;
				}
				_ownerID = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("clueIndex")] 
		public CInt32 ClueIndex
		{
			get
			{
				if (_clueIndex == null)
				{
					_clueIndex = (CInt32) CR2WTypeManager.Create("Int32", "clueIndex", cr2w, this);
				}
				return _clueIndex;
			}
			set
			{
				if (_clueIndex == value)
				{
					return;
				}
				_clueIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
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

		[Ordinal(4)] 
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

		[Ordinal(5)] 
		[RED("isScanned")] 
		public CBool IsScanned
		{
			get
			{
				if (_isScanned == null)
				{
					_isScanned = (CBool) CR2WTypeManager.Create("Bool", "isScanned", cr2w, this);
				}
				return _isScanned;
			}
			set
			{
				if (_isScanned == value)
				{
					return;
				}
				_isScanned = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
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

		[Ordinal(7)] 
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

		[Ordinal(8)] 
		[RED("psData")] 
		public PSOwnerData PsData
		{
			get
			{
				if (_psData == null)
				{
					_psData = (PSOwnerData) CR2WTypeManager.Create("PSOwnerData", "psData", cr2w, this);
				}
				return _psData;
			}
			set
			{
				if (_psData == value)
				{
					return;
				}
				_psData = value;
				PropertySet(this);
			}
		}

		public LinkedFocusClueData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
