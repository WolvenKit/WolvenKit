using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WindowBlindersReplicatedState : gameDeviceReplicatedState
	{
		private CBool _isOpen;
		private CBool _isTilted;

		[Ordinal(0)] 
		[RED("isOpen")] 
		public CBool IsOpen
		{
			get
			{
				if (_isOpen == null)
				{
					_isOpen = (CBool) CR2WTypeManager.Create("Bool", "isOpen", cr2w, this);
				}
				return _isOpen;
			}
			set
			{
				if (_isOpen == value)
				{
					return;
				}
				_isOpen = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("isTilted")] 
		public CBool IsTilted
		{
			get
			{
				if (_isTilted == null)
				{
					_isTilted = (CBool) CR2WTypeManager.Create("Bool", "isTilted", cr2w, this);
				}
				return _isTilted;
			}
			set
			{
				if (_isTilted == value)
				{
					return;
				}
				_isTilted = value;
				PropertySet(this);
			}
		}

		public WindowBlindersReplicatedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
