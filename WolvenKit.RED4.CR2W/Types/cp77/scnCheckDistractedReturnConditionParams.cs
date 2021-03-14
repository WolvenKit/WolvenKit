using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnCheckDistractedReturnConditionParams : CVariable
	{
		private CBool _distracted;
		private CEnum<scnDistractedConditionTarget> _target;

		[Ordinal(0)] 
		[RED("distracted")] 
		public CBool Distracted
		{
			get
			{
				if (_distracted == null)
				{
					_distracted = (CBool) CR2WTypeManager.Create("Bool", "distracted", cr2w, this);
				}
				return _distracted;
			}
			set
			{
				if (_distracted == value)
				{
					return;
				}
				_distracted = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("target")] 
		public CEnum<scnDistractedConditionTarget> Target
		{
			get
			{
				if (_target == null)
				{
					_target = (CEnum<scnDistractedConditionTarget>) CR2WTypeManager.Create("scnDistractedConditionTarget", "target", cr2w, this);
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

		public scnCheckDistractedReturnConditionParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
