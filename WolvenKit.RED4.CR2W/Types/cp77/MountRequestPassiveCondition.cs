using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MountRequestPassiveCondition : AIbehaviorexpressionScript
	{
		private CBool _unmountRequest;
		private CBool _acceptInstant;
		private CBool _acceptNotInstant;
		private CBool _acceptForcedTransition;
		private CUInt32 _callbackId;
		private CUInt32 _highLevelStateCallbackId;

		[Ordinal(0)] 
		[RED("unmountRequest")] 
		public CBool UnmountRequest
		{
			get
			{
				if (_unmountRequest == null)
				{
					_unmountRequest = (CBool) CR2WTypeManager.Create("Bool", "unmountRequest", cr2w, this);
				}
				return _unmountRequest;
			}
			set
			{
				if (_unmountRequest == value)
				{
					return;
				}
				_unmountRequest = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("acceptInstant")] 
		public CBool AcceptInstant
		{
			get
			{
				if (_acceptInstant == null)
				{
					_acceptInstant = (CBool) CR2WTypeManager.Create("Bool", "acceptInstant", cr2w, this);
				}
				return _acceptInstant;
			}
			set
			{
				if (_acceptInstant == value)
				{
					return;
				}
				_acceptInstant = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("acceptNotInstant")] 
		public CBool AcceptNotInstant
		{
			get
			{
				if (_acceptNotInstant == null)
				{
					_acceptNotInstant = (CBool) CR2WTypeManager.Create("Bool", "acceptNotInstant", cr2w, this);
				}
				return _acceptNotInstant;
			}
			set
			{
				if (_acceptNotInstant == value)
				{
					return;
				}
				_acceptNotInstant = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("acceptForcedTransition")] 
		public CBool AcceptForcedTransition
		{
			get
			{
				if (_acceptForcedTransition == null)
				{
					_acceptForcedTransition = (CBool) CR2WTypeManager.Create("Bool", "acceptForcedTransition", cr2w, this);
				}
				return _acceptForcedTransition;
			}
			set
			{
				if (_acceptForcedTransition == value)
				{
					return;
				}
				_acceptForcedTransition = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("callbackId")] 
		public CUInt32 CallbackId
		{
			get
			{
				if (_callbackId == null)
				{
					_callbackId = (CUInt32) CR2WTypeManager.Create("Uint32", "callbackId", cr2w, this);
				}
				return _callbackId;
			}
			set
			{
				if (_callbackId == value)
				{
					return;
				}
				_callbackId = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("highLevelStateCallbackId")] 
		public CUInt32 HighLevelStateCallbackId
		{
			get
			{
				if (_highLevelStateCallbackId == null)
				{
					_highLevelStateCallbackId = (CUInt32) CR2WTypeManager.Create("Uint32", "highLevelStateCallbackId", cr2w, this);
				}
				return _highLevelStateCallbackId;
			}
			set
			{
				if (_highLevelStateCallbackId == value)
				{
					return;
				}
				_highLevelStateCallbackId = value;
				PropertySet(this);
			}
		}

		public MountRequestPassiveCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
