using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class workSyncAnimClip : workAnimClip
	{
		private CName _slotName;
		private Transform _syncOffset;

		[Ordinal(4)] 
		[RED("slotName")] 
		public CName SlotName
		{
			get
			{
				if (_slotName == null)
				{
					_slotName = (CName) CR2WTypeManager.Create("CName", "slotName", cr2w, this);
				}
				return _slotName;
			}
			set
			{
				if (_slotName == value)
				{
					return;
				}
				_slotName = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("syncOffset")] 
		public Transform SyncOffset
		{
			get
			{
				if (_syncOffset == null)
				{
					_syncOffset = (Transform) CR2WTypeManager.Create("Transform", "syncOffset", cr2w, this);
				}
				return _syncOffset;
			}
			set
			{
				if (_syncOffset == value)
				{
					return;
				}
				_syncOffset = value;
				PropertySet(this);
			}
		}

		public workSyncAnimClip(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
