using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ApplyEffectorEffector : gameEffector
	{
		private entEntityID _target;
		private CString _applicationTarget;
		private TweakDBID _effectorToApply;

		[Ordinal(0)] 
		[RED("target")] 
		public entEntityID Target
		{
			get
			{
				if (_target == null)
				{
					_target = (entEntityID) CR2WTypeManager.Create("entEntityID", "target", cr2w, this);
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
		[RED("effectorToApply")] 
		public TweakDBID EffectorToApply
		{
			get
			{
				if (_effectorToApply == null)
				{
					_effectorToApply = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "effectorToApply", cr2w, this);
				}
				return _effectorToApply;
			}
			set
			{
				if (_effectorToApply == value)
				{
					return;
				}
				_effectorToApply = value;
				PropertySet(this);
			}
		}

		public ApplyEffectorEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
