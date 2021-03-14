using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ActionCooldownEvent : redEvent
	{
		private CooldownStorageID _storageID;

		[Ordinal(0)] 
		[RED("storageID")] 
		public CooldownStorageID StorageID
		{
			get
			{
				if (_storageID == null)
				{
					_storageID = (CooldownStorageID) CR2WTypeManager.Create("CooldownStorageID", "storageID", cr2w, this);
				}
				return _storageID;
			}
			set
			{
				if (_storageID == value)
				{
					return;
				}
				_storageID = value;
				PropertySet(this);
			}
		}

		public ActionCooldownEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
