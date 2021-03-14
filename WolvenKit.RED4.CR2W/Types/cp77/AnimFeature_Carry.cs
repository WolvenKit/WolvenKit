using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_Carry : animAnimFeature
	{
		private CInt32 _state;
		private CInt32 _pickupAnimation;
		private CBool _useBothHands;
		private CBool _instant;

		[Ordinal(0)] 
		[RED("state")] 
		public CInt32 State
		{
			get
			{
				if (_state == null)
				{
					_state = (CInt32) CR2WTypeManager.Create("Int32", "state", cr2w, this);
				}
				return _state;
			}
			set
			{
				if (_state == value)
				{
					return;
				}
				_state = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("pickupAnimation")] 
		public CInt32 PickupAnimation
		{
			get
			{
				if (_pickupAnimation == null)
				{
					_pickupAnimation = (CInt32) CR2WTypeManager.Create("Int32", "pickupAnimation", cr2w, this);
				}
				return _pickupAnimation;
			}
			set
			{
				if (_pickupAnimation == value)
				{
					return;
				}
				_pickupAnimation = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("useBothHands")] 
		public CBool UseBothHands
		{
			get
			{
				if (_useBothHands == null)
				{
					_useBothHands = (CBool) CR2WTypeManager.Create("Bool", "useBothHands", cr2w, this);
				}
				return _useBothHands;
			}
			set
			{
				if (_useBothHands == value)
				{
					return;
				}
				_useBothHands = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("instant")] 
		public CBool Instant
		{
			get
			{
				if (_instant == null)
				{
					_instant = (CBool) CR2WTypeManager.Create("Bool", "instant", cr2w, this);
				}
				return _instant;
			}
			set
			{
				if (_instant == value)
				{
					return;
				}
				_instant = value;
				PropertySet(this);
			}
		}

		public AnimFeature_Carry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
