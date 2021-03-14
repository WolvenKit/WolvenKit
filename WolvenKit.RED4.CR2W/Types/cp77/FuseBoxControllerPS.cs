using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FuseBoxControllerPS : MasterControllerPS
	{
		private CHandle<EngineeringContainer> _fuseBoxSkillChecks;
		private CBool _isGenerator;
		private CBool _isOverloaded;

		[Ordinal(104)] 
		[RED("fuseBoxSkillChecks")] 
		public CHandle<EngineeringContainer> FuseBoxSkillChecks
		{
			get
			{
				if (_fuseBoxSkillChecks == null)
				{
					_fuseBoxSkillChecks = (CHandle<EngineeringContainer>) CR2WTypeManager.Create("handle:EngineeringContainer", "fuseBoxSkillChecks", cr2w, this);
				}
				return _fuseBoxSkillChecks;
			}
			set
			{
				if (_fuseBoxSkillChecks == value)
				{
					return;
				}
				_fuseBoxSkillChecks = value;
				PropertySet(this);
			}
		}

		[Ordinal(105)] 
		[RED("isGenerator")] 
		public CBool IsGenerator
		{
			get
			{
				if (_isGenerator == null)
				{
					_isGenerator = (CBool) CR2WTypeManager.Create("Bool", "isGenerator", cr2w, this);
				}
				return _isGenerator;
			}
			set
			{
				if (_isGenerator == value)
				{
					return;
				}
				_isGenerator = value;
				PropertySet(this);
			}
		}

		[Ordinal(106)] 
		[RED("isOverloaded")] 
		public CBool IsOverloaded
		{
			get
			{
				if (_isOverloaded == null)
				{
					_isOverloaded = (CBool) CR2WTypeManager.Create("Bool", "isOverloaded", cr2w, this);
				}
				return _isOverloaded;
			}
			set
			{
				if (_isOverloaded == value)
				{
					return;
				}
				_isOverloaded = value;
				PropertySet(this);
			}
		}

		public FuseBoxControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
