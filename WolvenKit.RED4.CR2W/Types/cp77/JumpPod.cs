using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class JumpPod : gameObject
	{
		private CHandle<entIVisualComponent> _activationLight;
		private CHandle<entIComponent> _activationTrigger;
		private CFloat _impulseForward;
		private CFloat _impulseRight;
		private CFloat _impulseUp;

		[Ordinal(40)] 
		[RED("activationLight")] 
		public CHandle<entIVisualComponent> ActivationLight
		{
			get
			{
				if (_activationLight == null)
				{
					_activationLight = (CHandle<entIVisualComponent>) CR2WTypeManager.Create("handle:entIVisualComponent", "activationLight", cr2w, this);
				}
				return _activationLight;
			}
			set
			{
				if (_activationLight == value)
				{
					return;
				}
				_activationLight = value;
				PropertySet(this);
			}
		}

		[Ordinal(41)] 
		[RED("activationTrigger")] 
		public CHandle<entIComponent> ActivationTrigger
		{
			get
			{
				if (_activationTrigger == null)
				{
					_activationTrigger = (CHandle<entIComponent>) CR2WTypeManager.Create("handle:entIComponent", "activationTrigger", cr2w, this);
				}
				return _activationTrigger;
			}
			set
			{
				if (_activationTrigger == value)
				{
					return;
				}
				_activationTrigger = value;
				PropertySet(this);
			}
		}

		[Ordinal(42)] 
		[RED("impulseForward")] 
		public CFloat ImpulseForward
		{
			get
			{
				if (_impulseForward == null)
				{
					_impulseForward = (CFloat) CR2WTypeManager.Create("Float", "impulseForward", cr2w, this);
				}
				return _impulseForward;
			}
			set
			{
				if (_impulseForward == value)
				{
					return;
				}
				_impulseForward = value;
				PropertySet(this);
			}
		}

		[Ordinal(43)] 
		[RED("impulseRight")] 
		public CFloat ImpulseRight
		{
			get
			{
				if (_impulseRight == null)
				{
					_impulseRight = (CFloat) CR2WTypeManager.Create("Float", "impulseRight", cr2w, this);
				}
				return _impulseRight;
			}
			set
			{
				if (_impulseRight == value)
				{
					return;
				}
				_impulseRight = value;
				PropertySet(this);
			}
		}

		[Ordinal(44)] 
		[RED("impulseUp")] 
		public CFloat ImpulseUp
		{
			get
			{
				if (_impulseUp == null)
				{
					_impulseUp = (CFloat) CR2WTypeManager.Create("Float", "impulseUp", cr2w, this);
				}
				return _impulseUp;
			}
			set
			{
				if (_impulseUp == value)
				{
					return;
				}
				_impulseUp = value;
				PropertySet(this);
			}
		}

		public JumpPod(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
