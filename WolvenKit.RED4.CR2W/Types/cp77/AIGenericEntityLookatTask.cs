using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIGenericEntityLookatTask : AIGenericLookatTask
	{
		private CHandle<entLookAtAddEvent> _lookAtEvent;
		private CFloat _activationTimeStamp;
		private wCHandle<entEntity> _lookatTarget;

		[Ordinal(0)] 
		[RED("lookAtEvent")] 
		public CHandle<entLookAtAddEvent> LookAtEvent
		{
			get
			{
				if (_lookAtEvent == null)
				{
					_lookAtEvent = (CHandle<entLookAtAddEvent>) CR2WTypeManager.Create("handle:entLookAtAddEvent", "lookAtEvent", cr2w, this);
				}
				return _lookAtEvent;
			}
			set
			{
				if (_lookAtEvent == value)
				{
					return;
				}
				_lookAtEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("activationTimeStamp")] 
		public CFloat ActivationTimeStamp
		{
			get
			{
				if (_activationTimeStamp == null)
				{
					_activationTimeStamp = (CFloat) CR2WTypeManager.Create("Float", "activationTimeStamp", cr2w, this);
				}
				return _activationTimeStamp;
			}
			set
			{
				if (_activationTimeStamp == value)
				{
					return;
				}
				_activationTimeStamp = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("lookatTarget")] 
		public wCHandle<entEntity> LookatTarget
		{
			get
			{
				if (_lookatTarget == null)
				{
					_lookatTarget = (wCHandle<entEntity>) CR2WTypeManager.Create("whandle:entEntity", "lookatTarget", cr2w, this);
				}
				return _lookatTarget;
			}
			set
			{
				if (_lookatTarget == value)
				{
					return;
				}
				_lookatTarget = value;
				PropertySet(this);
			}
		}

		public AIGenericEntityLookatTask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
