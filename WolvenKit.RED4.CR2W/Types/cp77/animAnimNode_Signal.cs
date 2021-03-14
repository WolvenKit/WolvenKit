using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_Signal : animAnimNode_FloatValue
	{
		private CFloat _blendIn;
		private CFloat _blendOut;
		private CName _startEvent;
		private CName _endEvent;
		private CBool _defaultState;
		private CFloat _cooldown;

		[Ordinal(11)] 
		[RED("blendIn")] 
		public CFloat BlendIn
		{
			get
			{
				if (_blendIn == null)
				{
					_blendIn = (CFloat) CR2WTypeManager.Create("Float", "blendIn", cr2w, this);
				}
				return _blendIn;
			}
			set
			{
				if (_blendIn == value)
				{
					return;
				}
				_blendIn = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("blendOut")] 
		public CFloat BlendOut
		{
			get
			{
				if (_blendOut == null)
				{
					_blendOut = (CFloat) CR2WTypeManager.Create("Float", "blendOut", cr2w, this);
				}
				return _blendOut;
			}
			set
			{
				if (_blendOut == value)
				{
					return;
				}
				_blendOut = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("startEvent")] 
		public CName StartEvent
		{
			get
			{
				if (_startEvent == null)
				{
					_startEvent = (CName) CR2WTypeManager.Create("CName", "startEvent", cr2w, this);
				}
				return _startEvent;
			}
			set
			{
				if (_startEvent == value)
				{
					return;
				}
				_startEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("endEvent")] 
		public CName EndEvent
		{
			get
			{
				if (_endEvent == null)
				{
					_endEvent = (CName) CR2WTypeManager.Create("CName", "endEvent", cr2w, this);
				}
				return _endEvent;
			}
			set
			{
				if (_endEvent == value)
				{
					return;
				}
				_endEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("defaultState")] 
		public CBool DefaultState
		{
			get
			{
				if (_defaultState == null)
				{
					_defaultState = (CBool) CR2WTypeManager.Create("Bool", "defaultState", cr2w, this);
				}
				return _defaultState;
			}
			set
			{
				if (_defaultState == value)
				{
					return;
				}
				_defaultState = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("cooldown")] 
		public CFloat Cooldown
		{
			get
			{
				if (_cooldown == null)
				{
					_cooldown = (CFloat) CR2WTypeManager.Create("Float", "cooldown", cr2w, this);
				}
				return _cooldown;
			}
			set
			{
				if (_cooldown == value)
				{
					return;
				}
				_cooldown = value;
				PropertySet(this);
			}
		}

		public animAnimNode_Signal(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
