using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DoorReplicatedState : gameDeviceReplicatedState
	{
		private CBool _isOpen;
		private CBool _wasImmediateChange;

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
		[RED("wasImmediateChange")] 
		public CBool WasImmediateChange
		{
			get
			{
				if (_wasImmediateChange == null)
				{
					_wasImmediateChange = (CBool) CR2WTypeManager.Create("Bool", "wasImmediateChange", cr2w, this);
				}
				return _wasImmediateChange;
			}
			set
			{
				if (_wasImmediateChange == value)
				{
					return;
				}
				_wasImmediateChange = value;
				PropertySet(this);
			}
		}

		public DoorReplicatedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
