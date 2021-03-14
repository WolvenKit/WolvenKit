using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VehicleWindowClose : ActionBool
	{
		private CName _slotID;
		private CName _speed;
		private CBool _isInteractionSource;

		[Ordinal(25)] 
		[RED("slotID")] 
		public CName SlotID
		{
			get
			{
				if (_slotID == null)
				{
					_slotID = (CName) CR2WTypeManager.Create("CName", "slotID", cr2w, this);
				}
				return _slotID;
			}
			set
			{
				if (_slotID == value)
				{
					return;
				}
				_slotID = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("speed")] 
		public CName Speed
		{
			get
			{
				if (_speed == null)
				{
					_speed = (CName) CR2WTypeManager.Create("CName", "speed", cr2w, this);
				}
				return _speed;
			}
			set
			{
				if (_speed == value)
				{
					return;
				}
				_speed = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("isInteractionSource")] 
		public CBool IsInteractionSource
		{
			get
			{
				if (_isInteractionSource == null)
				{
					_isInteractionSource = (CBool) CR2WTypeManager.Create("Bool", "isInteractionSource", cr2w, this);
				}
				return _isInteractionSource;
			}
			set
			{
				if (_isInteractionSource == value)
				{
					return;
				}
				_isInteractionSource = value;
				PropertySet(this);
			}
		}

		public VehicleWindowClose(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
