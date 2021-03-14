using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DropPointControllerPS : BasicDistractionDeviceControllerPS
	{
		private CString _vendorRecord;
		private CArray<TweakDBID> _rewardsLootTable;
		private CBool _hasPlayerCollectedReward;

		[Ordinal(108)] 
		[RED("vendorRecord")] 
		public CString VendorRecord
		{
			get
			{
				if (_vendorRecord == null)
				{
					_vendorRecord = (CString) CR2WTypeManager.Create("String", "vendorRecord", cr2w, this);
				}
				return _vendorRecord;
			}
			set
			{
				if (_vendorRecord == value)
				{
					return;
				}
				_vendorRecord = value;
				PropertySet(this);
			}
		}

		[Ordinal(109)] 
		[RED("rewardsLootTable")] 
		public CArray<TweakDBID> RewardsLootTable
		{
			get
			{
				if (_rewardsLootTable == null)
				{
					_rewardsLootTable = (CArray<TweakDBID>) CR2WTypeManager.Create("array:TweakDBID", "rewardsLootTable", cr2w, this);
				}
				return _rewardsLootTable;
			}
			set
			{
				if (_rewardsLootTable == value)
				{
					return;
				}
				_rewardsLootTable = value;
				PropertySet(this);
			}
		}

		[Ordinal(110)] 
		[RED("hasPlayerCollectedReward")] 
		public CBool HasPlayerCollectedReward
		{
			get
			{
				if (_hasPlayerCollectedReward == null)
				{
					_hasPlayerCollectedReward = (CBool) CR2WTypeManager.Create("Bool", "hasPlayerCollectedReward", cr2w, this);
				}
				return _hasPlayerCollectedReward;
			}
			set
			{
				if (_hasPlayerCollectedReward == value)
				{
					return;
				}
				_hasPlayerCollectedReward = value;
				PropertySet(this);
			}
		}

		public DropPointControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
