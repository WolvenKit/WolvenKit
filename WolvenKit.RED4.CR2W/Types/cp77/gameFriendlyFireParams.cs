using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameFriendlyFireParams : IScriptable
	{
		private wCHandle<gameAttitudeAgent> _attitude;
		private wCHandle<entSlotComponent> _slots;
		private CName _attachmentName;
		private CInt32 _slotId;
		private CFloat _spread;
		private CFloat _maxRange;

		[Ordinal(0)] 
		[RED("attitude")] 
		public wCHandle<gameAttitudeAgent> Attitude
		{
			get
			{
				if (_attitude == null)
				{
					_attitude = (wCHandle<gameAttitudeAgent>) CR2WTypeManager.Create("whandle:gameAttitudeAgent", "attitude", cr2w, this);
				}
				return _attitude;
			}
			set
			{
				if (_attitude == value)
				{
					return;
				}
				_attitude = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("slots")] 
		public wCHandle<entSlotComponent> Slots
		{
			get
			{
				if (_slots == null)
				{
					_slots = (wCHandle<entSlotComponent>) CR2WTypeManager.Create("whandle:entSlotComponent", "slots", cr2w, this);
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

		[Ordinal(2)] 
		[RED("attachmentName")] 
		public CName AttachmentName
		{
			get
			{
				if (_attachmentName == null)
				{
					_attachmentName = (CName) CR2WTypeManager.Create("CName", "attachmentName", cr2w, this);
				}
				return _attachmentName;
			}
			set
			{
				if (_attachmentName == value)
				{
					return;
				}
				_attachmentName = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("slotId")] 
		public CInt32 SlotId
		{
			get
			{
				if (_slotId == null)
				{
					_slotId = (CInt32) CR2WTypeManager.Create("Int32", "slotId", cr2w, this);
				}
				return _slotId;
			}
			set
			{
				if (_slotId == value)
				{
					return;
				}
				_slotId = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("spread")] 
		public CFloat Spread
		{
			get
			{
				if (_spread == null)
				{
					_spread = (CFloat) CR2WTypeManager.Create("Float", "spread", cr2w, this);
				}
				return _spread;
			}
			set
			{
				if (_spread == value)
				{
					return;
				}
				_spread = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("maxRange")] 
		public CFloat MaxRange
		{
			get
			{
				if (_maxRange == null)
				{
					_maxRange = (CFloat) CR2WTypeManager.Create("Float", "maxRange", cr2w, this);
				}
				return _maxRange;
			}
			set
			{
				if (_maxRange == value)
				{
					return;
				}
				_maxRange = value;
				PropertySet(this);
			}
		}

		public gameFriendlyFireParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
