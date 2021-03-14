using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class IsNpcPlayingMountingAnimationPrereq : gameIScriptablePrereq
	{
		private CName _slotName;
		private CBool _isCheckInverted;

		[Ordinal(0)] 
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

		[Ordinal(1)] 
		[RED("isCheckInverted")] 
		public CBool IsCheckInverted
		{
			get
			{
				if (_isCheckInverted == null)
				{
					_isCheckInverted = (CBool) CR2WTypeManager.Create("Bool", "isCheckInverted", cr2w, this);
				}
				return _isCheckInverted;
			}
			set
			{
				if (_isCheckInverted == value)
				{
					return;
				}
				_isCheckInverted = value;
				PropertySet(this);
			}
		}

		public IsNpcPlayingMountingAnimationPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
