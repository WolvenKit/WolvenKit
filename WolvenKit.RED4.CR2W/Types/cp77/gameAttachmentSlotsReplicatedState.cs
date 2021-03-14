using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameAttachmentSlotsReplicatedState : netIComponentState
	{
		private CUInt32 _stateVersion;
		private CArray<gameAttachmentSlotReplicatedState> _slots;

		[Ordinal(2)] 
		[RED("stateVersion")] 
		public CUInt32 StateVersion
		{
			get
			{
				if (_stateVersion == null)
				{
					_stateVersion = (CUInt32) CR2WTypeManager.Create("Uint32", "stateVersion", cr2w, this);
				}
				return _stateVersion;
			}
			set
			{
				if (_stateVersion == value)
				{
					return;
				}
				_stateVersion = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("slots")] 
		public CArray<gameAttachmentSlotReplicatedState> Slots
		{
			get
			{
				if (_slots == null)
				{
					_slots = (CArray<gameAttachmentSlotReplicatedState>) CR2WTypeManager.Create("array:gameAttachmentSlotReplicatedState", "slots", cr2w, this);
				}
				return _slots;
			}
			set
			{
				if (_slots == value)
				{
					return;
				}
				_slots = value;
				PropertySet(this);
			}
		}

		public gameAttachmentSlotsReplicatedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
