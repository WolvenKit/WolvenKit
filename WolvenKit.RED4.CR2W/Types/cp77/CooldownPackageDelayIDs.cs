using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CooldownPackageDelayIDs : CVariable
	{
		private CooldownStorageID _packageID;
		private CArray<gameDelayID> _delayIDs;

		[Ordinal(0)] 
		[RED("packageID")] 
		public CooldownStorageID PackageID
		{
			get
			{
				if (_packageID == null)
				{
					_packageID = (CooldownStorageID) CR2WTypeManager.Create("CooldownStorageID", "packageID", cr2w, this);
				}
				return _packageID;
			}
			set
			{
				if (_packageID == value)
				{
					return;
				}
				_packageID = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("delayIDs")] 
		public CArray<gameDelayID> DelayIDs
		{
			get
			{
				if (_delayIDs == null)
				{
					_delayIDs = (CArray<gameDelayID>) CR2WTypeManager.Create("array:gameDelayID", "delayIDs", cr2w, this);
				}
				return _delayIDs;
			}
			set
			{
				if (_delayIDs == value)
				{
					return;
				}
				_delayIDs = value;
				PropertySet(this);
			}
		}

		public CooldownPackageDelayIDs(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
