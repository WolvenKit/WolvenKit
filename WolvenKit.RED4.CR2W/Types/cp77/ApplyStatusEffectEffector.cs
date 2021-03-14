using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ApplyStatusEffectEffector : gameEffector
	{
		private wCHandle<gameObject> _target;
		private CString _applicationTarget;
		private TweakDBID _record;
		private CBool _removeWithEffector;
		private CBool _inverted;
		private CFloat _count;
		private CString _instigator;

		[Ordinal(0)] 
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

		[Ordinal(1)] 
		[RED("applicationTarget")] 
		public CString ApplicationTarget
		{
			get
			{
				if (_applicationTarget == null)
				{
					_applicationTarget = (CString) CR2WTypeManager.Create("String", "applicationTarget", cr2w, this);
				}
				return _applicationTarget;
			}
			set
			{
				if (_applicationTarget == value)
				{
					return;
				}
				_applicationTarget = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("record")] 
		public TweakDBID Record
		{
			get
			{
				if (_record == null)
				{
					_record = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "record", cr2w, this);
				}
				return _record;
			}
			set
			{
				if (_record == value)
				{
					return;
				}
				_record = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("removeWithEffector")] 
		public CBool RemoveWithEffector
		{
			get
			{
				if (_removeWithEffector == null)
				{
					_removeWithEffector = (CBool) CR2WTypeManager.Create("Bool", "removeWithEffector", cr2w, this);
				}
				return _removeWithEffector;
			}
			set
			{
				if (_removeWithEffector == value)
				{
					return;
				}
				_removeWithEffector = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
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

		[Ordinal(5)] 
		[RED("count")] 
		public CFloat Count
		{
			get
			{
				if (_count == null)
				{
					_count = (CFloat) CR2WTypeManager.Create("Float", "count", cr2w, this);
				}
				return _count;
			}
			set
			{
				if (_count == value)
				{
					return;
				}
				_count = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("instigator")] 
		public CString Instigator
		{
			get
			{
				if (_instigator == null)
				{
					_instigator = (CString) CR2WTypeManager.Create("String", "instigator", cr2w, this);
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

		public ApplyStatusEffectEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
