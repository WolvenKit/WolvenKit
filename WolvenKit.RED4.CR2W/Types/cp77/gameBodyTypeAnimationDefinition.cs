using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameBodyTypeAnimationDefinition : CVariable
	{
		private raRef<animRig> _rig;
		private CArray<raRef<animAnimSet>> _animsets;
		private CArray<gameAnimationOverrideDefinition> _overrides;

		[Ordinal(0)] 
		[RED("rig")] 
		public raRef<animRig> Rig
		{
			get
			{
				if (_rig == null)
				{
					_rig = (raRef<animRig>) CR2WTypeManager.Create("raRef:animRig", "rig", cr2w, this);
				}
				return _rig;
			}
			set
			{
				if (_rig == value)
				{
					return;
				}
				_rig = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("animsets")] 
		public CArray<raRef<animAnimSet>> Animsets
		{
			get
			{
				if (_animsets == null)
				{
					_animsets = (CArray<raRef<animAnimSet>>) CR2WTypeManager.Create("array:raRef:animAnimSet", "animsets", cr2w, this);
				}
				return _animsets;
			}
			set
			{
				if (_animsets == value)
				{
					return;
				}
				_animsets = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("overrides")] 
		public CArray<gameAnimationOverrideDefinition> Overrides
		{
			get
			{
				if (_overrides == null)
				{
					_overrides = (CArray<gameAnimationOverrideDefinition>) CR2WTypeManager.Create("array:gameAnimationOverrideDefinition", "overrides", cr2w, this);
				}
				return _overrides;
			}
			set
			{
				if (_overrides == value)
				{
					return;
				}
				_overrides = value;
				PropertySet(this);
			}
		}

		public gameBodyTypeAnimationDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
