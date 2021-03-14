using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questVision_ConditionType : questISensesConditionType
	{
		private gameEntityReference _observerPuppetRef;
		private gameEntityReference _observedTargetRef;
		private CBool _isObservedTargetPlayer;
		private CBool _inverted;
		private CBool _isInstant;

		[Ordinal(0)] 
		[RED("observerPuppetRef")] 
		public gameEntityReference ObserverPuppetRef
		{
			get
			{
				if (_observerPuppetRef == null)
				{
					_observerPuppetRef = (gameEntityReference) CR2WTypeManager.Create("gameEntityReference", "observerPuppetRef", cr2w, this);
				}
				return _observerPuppetRef;
			}
			set
			{
				if (_observerPuppetRef == value)
				{
					return;
				}
				_observerPuppetRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("observedTargetRef")] 
		public gameEntityReference ObservedTargetRef
		{
			get
			{
				if (_observedTargetRef == null)
				{
					_observedTargetRef = (gameEntityReference) CR2WTypeManager.Create("gameEntityReference", "observedTargetRef", cr2w, this);
				}
				return _observedTargetRef;
			}
			set
			{
				if (_observedTargetRef == value)
				{
					return;
				}
				_observedTargetRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("isObservedTargetPlayer")] 
		public CBool IsObservedTargetPlayer
		{
			get
			{
				if (_isObservedTargetPlayer == null)
				{
					_isObservedTargetPlayer = (CBool) CR2WTypeManager.Create("Bool", "isObservedTargetPlayer", cr2w, this);
				}
				return _isObservedTargetPlayer;
			}
			set
			{
				if (_isObservedTargetPlayer == value)
				{
					return;
				}
				_isObservedTargetPlayer = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("inverted")] 
		public CBool Inverted
		{
			get
			{
				if (_inverted == null)
				{
					_inverted = (CBool) CR2WTypeManager.Create("Bool", "inverted", cr2w, this);
				}
				return _inverted;
			}
			set
			{
				if (_inverted == value)
				{
					return;
				}
				_inverted = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("isInstant")] 
		public CBool IsInstant
		{
			get
			{
				if (_isInstant == null)
				{
					_isInstant = (CBool) CR2WTypeManager.Create("Bool", "isInstant", cr2w, this);
				}
				return _isInstant;
			}
			set
			{
				if (_isInstant == value)
				{
					return;
				}
				_isInstant = value;
				PropertySet(this);
			}
		}

		public questVision_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
