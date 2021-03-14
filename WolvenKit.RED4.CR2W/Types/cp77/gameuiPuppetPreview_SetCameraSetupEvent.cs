using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiPuppetPreview_SetCameraSetupEvent : redEvent
	{
		private CUInt32 _setupIndex;
		private CName _slotName;
		private CBool _delayed;

		[Ordinal(0)] 
		[RED("setupIndex")] 
		public CUInt32 SetupIndex
		{
			get
			{
				if (_setupIndex == null)
				{
					_setupIndex = (CUInt32) CR2WTypeManager.Create("Uint32", "setupIndex", cr2w, this);
				}
				return _setupIndex;
			}
			set
			{
				if (_setupIndex == value)
				{
					return;
				}
				_setupIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
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

		[Ordinal(2)] 
		[RED("delayed")] 
		public CBool Delayed
		{
			get
			{
				if (_delayed == null)
				{
					_delayed = (CBool) CR2WTypeManager.Create("Bool", "delayed", cr2w, this);
				}
				return _delayed;
			}
			set
			{
				if (_delayed == value)
				{
					return;
				}
				_delayed = value;
				PropertySet(this);
			}
		}

		public gameuiPuppetPreview_SetCameraSetupEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
