using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameAnimationOverrideDefinition : CVariable
	{
		private raRef<animAnimSet> _animset;
		private CArray<CName> _variables;

		[Ordinal(0)] 
		[RED("animset")] 
		public raRef<animAnimSet> Animset
		{
			get
			{
				if (_animset == null)
				{
					_animset = (raRef<animAnimSet>) CR2WTypeManager.Create("raRef:animAnimSet", "animset", cr2w, this);
				}
				return _animset;
			}
			set
			{
				if (_animset == value)
				{
					return;
				}
				_animset = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("variables")] 
		public CArray<CName> Variables
		{
			get
			{
				if (_variables == null)
				{
					_variables = (CArray<CName>) CR2WTypeManager.Create("array:CName", "variables", cr2w, this);
				}
				return _variables;
			}
			set
			{
				if (_variables == value)
				{
					return;
				}
				_variables = value;
				PropertySet(this);
			}
		}

		public gameAnimationOverrideDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
