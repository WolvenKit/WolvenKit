using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIGenericStaticLookatTask : AIGenericLookatTask
	{
		private CHandle<entLookAtAddEvent> _lookAtEvent;
		private CFloat _activationTimeStamp;
		private Vector4 _lookatTarget;
		private Vector4 _currentLookatTarget;

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
		public Vector4 LookatTarget
		{
			get
			{
				if (_lookatTarget == null)
				{
					_lookatTarget = (Vector4) CR2WTypeManager.Create("Vector4", "lookatTarget", cr2w, this);
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

		[Ordinal(3)] 
		[RED("currentLookatTarget")] 
		public Vector4 CurrentLookatTarget
		{
			get
			{
				if (_currentLookatTarget == null)
				{
					_currentLookatTarget = (Vector4) CR2WTypeManager.Create("Vector4", "currentLookatTarget", cr2w, this);
				}
				return _currentLookatTarget;
			}
			set
			{
				if (_currentLookatTarget == value)
				{
					return;
				}
				_currentLookatTarget = value;
				PropertySet(this);
			}
		}

		public AIGenericStaticLookatTask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
