using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameweaponeventsAIAttackAttemptEvent : redEvent
	{
		private wCHandle<gameObject> _instigator;
		private wCHandle<gameObject> _target;
		private CBool _isWindUp;
		private CEnum<gameEContinuousMode> _continuousMode;
		private CFloat _minimumOpacity;

		[Ordinal(0)] 
		[RED("instigator")] 
		public wCHandle<gameObject> Instigator
		{
			get
			{
				if (_instigator == null)
				{
					_instigator = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "instigator", cr2w, this);
				}
				return _instigator;
			}
			set
			{
				if (_instigator == value)
				{
					return;
				}
				_instigator = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("target")] 
		public wCHandle<gameObject> Target
		{
			get
			{
				if (_target == null)
				{
					_target = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "target", cr2w, this);
				}
				return _target;
			}
			set
			{
				if (_target == value)
				{
					return;
				}
				_target = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("isWindUp")] 
		public CBool IsWindUp
		{
			get
			{
				if (_isWindUp == null)
				{
					_isWindUp = (CBool) CR2WTypeManager.Create("Bool", "isWindUp", cr2w, this);
				}
				return _isWindUp;
			}
			set
			{
				if (_isWindUp == value)
				{
					return;
				}
				_isWindUp = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("continuousMode")] 
		public CEnum<gameEContinuousMode> ContinuousMode
		{
			get
			{
				if (_continuousMode == null)
				{
					_continuousMode = (CEnum<gameEContinuousMode>) CR2WTypeManager.Create("gameEContinuousMode", "continuousMode", cr2w, this);
				}
				return _continuousMode;
			}
			set
			{
				if (_continuousMode == value)
				{
					return;
				}
				_continuousMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("minimumOpacity")] 
		public CFloat MinimumOpacity
		{
			get
			{
				if (_minimumOpacity == null)
				{
					_minimumOpacity = (CFloat) CR2WTypeManager.Create("Float", "minimumOpacity", cr2w, this);
				}
				return _minimumOpacity;
			}
			set
			{
				if (_minimumOpacity == value)
				{
					return;
				}
				_minimumOpacity = value;
				PropertySet(this);
			}
		}

		public gameweaponeventsAIAttackAttemptEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
