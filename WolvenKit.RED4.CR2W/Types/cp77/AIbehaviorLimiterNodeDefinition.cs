using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorLimiterNodeDefinition : AIbehaviorDecoratorNodeDefinition
	{
		private CUInt32 _activationLimitPerFrame;
		private CBool _delayChildActivation;
		private CBool _delayChildActivationIfAttaching;

		[Ordinal(1)] 
		[RED("activationLimitPerFrame")] 
		public CUInt32 ActivationLimitPerFrame
		{
			get
			{
				if (_activationLimitPerFrame == null)
				{
					_activationLimitPerFrame = (CUInt32) CR2WTypeManager.Create("Uint32", "activationLimitPerFrame", cr2w, this);
				}
				return _activationLimitPerFrame;
			}
			set
			{
				if (_activationLimitPerFrame == value)
				{
					return;
				}
				_activationLimitPerFrame = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("delayChildActivation")] 
		public CBool DelayChildActivation
		{
			get
			{
				if (_delayChildActivation == null)
				{
					_delayChildActivation = (CBool) CR2WTypeManager.Create("Bool", "delayChildActivation", cr2w, this);
				}
				return _delayChildActivation;
			}
			set
			{
				if (_delayChildActivation == value)
				{
					return;
				}
				_delayChildActivation = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("delayChildActivationIfAttaching")] 
		public CBool DelayChildActivationIfAttaching
		{
			get
			{
				if (_delayChildActivationIfAttaching == null)
				{
					_delayChildActivationIfAttaching = (CBool) CR2WTypeManager.Create("Bool", "delayChildActivationIfAttaching", cr2w, this);
				}
				return _delayChildActivationIfAttaching;
			}
			set
			{
				if (_delayChildActivationIfAttaching == value)
				{
					return;
				}
				_delayChildActivationIfAttaching = value;
				PropertySet(this);
			}
		}

		public AIbehaviorLimiterNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
