using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DropPointPackage : IScriptable
	{
		private TweakDBID _itemID;
		private CEnum<DropPointPackageStatus> _status;
		private gamePersistentID _predefinedDrop;
		private CArray<CEnum<DropPointPackageStatus>> _statusHistory;

		[Ordinal(0)] 
		[RED("itemID")] 
		public TweakDBID ItemID
		{
			get
			{
				if (_itemID == null)
				{
					_itemID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "itemID", cr2w, this);
				}
				return _itemID;
			}
			set
			{
				if (_itemID == value)
				{
					return;
				}
				_itemID = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("status")] 
		public CEnum<DropPointPackageStatus> Status
		{
			get
			{
				if (_status == null)
				{
					_status = (CEnum<DropPointPackageStatus>) CR2WTypeManager.Create("DropPointPackageStatus", "status", cr2w, this);
				}
				return _status;
			}
			set
			{
				if (_status == value)
				{
					return;
				}
				_status = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("predefinedDrop")] 
		public gamePersistentID PredefinedDrop
		{
			get
			{
				if (_predefinedDrop == null)
				{
					_predefinedDrop = (gamePersistentID) CR2WTypeManager.Create("gamePersistentID", "predefinedDrop", cr2w, this);
				}
				return _predefinedDrop;
			}
			set
			{
				if (_predefinedDrop == value)
				{
					return;
				}
				_predefinedDrop = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("statusHistory")] 
		public CArray<CEnum<DropPointPackageStatus>> StatusHistory
		{
			get
			{
				if (_statusHistory == null)
				{
					_statusHistory = (CArray<CEnum<DropPointPackageStatus>>) CR2WTypeManager.Create("array:DropPointPackageStatus", "statusHistory", cr2w, this);
				}
				return _statusHistory;
			}
			set
			{
				if (_statusHistory == value)
				{
					return;
				}
				_statusHistory = value;
				PropertySet(this);
			}
		}

		public DropPointPackage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
