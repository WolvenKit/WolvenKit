using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ApplyRandomStatusEffectEffector : gameEffector
	{
		private wCHandle<gameObject> _target;
		private CString _applicationTarget;
		private CArray<TweakDBID> _effects;
		private TweakDBID _appliedEffect;

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
		[RED("effects")] 
		public CArray<TweakDBID> Effects
		{
			get
			{
				if (_effects == null)
				{
					_effects = (CArray<TweakDBID>) CR2WTypeManager.Create("array:TweakDBID", "effects", cr2w, this);
				}
				return _effects;
			}
			set
			{
				if (_effects == value)
				{
					return;
				}
				_effects = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("appliedEffect")] 
		public TweakDBID AppliedEffect
		{
			get
			{
				if (_appliedEffect == null)
				{
					_appliedEffect = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "appliedEffect", cr2w, this);
				}
				return _appliedEffect;
			}
			set
			{
				if (_appliedEffect == value)
				{
					return;
				}
				_appliedEffect = value;
				PropertySet(this);
			}
		}

		public ApplyRandomStatusEffectEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
