using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimSetCollection : CVariable
	{
		private CArray<raRef<animAnimSet>> _animSets;
		private CArray<animOverrideAnimSetRef> _overrideAnimSets;
		private CArray<animAnimWrapperVariableDescription> _animWrapperVariables;

		[Ordinal(0)] 
		[RED("animSets")] 
		public CArray<raRef<animAnimSet>> AnimSets
		{
			get
			{
				if (_animSets == null)
				{
					_animSets = (CArray<raRef<animAnimSet>>) CR2WTypeManager.Create("array:raRef:animAnimSet", "animSets", cr2w, this);
				}
				return _animSets;
			}
			set
			{
				if (_animSets == value)
				{
					return;
				}
				_animSets = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("overrideAnimSets")] 
		public CArray<animOverrideAnimSetRef> OverrideAnimSets
		{
			get
			{
				if (_overrideAnimSets == null)
				{
					_overrideAnimSets = (CArray<animOverrideAnimSetRef>) CR2WTypeManager.Create("array:animOverrideAnimSetRef", "overrideAnimSets", cr2w, this);
				}
				return _overrideAnimSets;
			}
			set
			{
				if (_overrideAnimSets == value)
				{
					return;
				}
				_overrideAnimSets = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("animWrapperVariables")] 
		public CArray<animAnimWrapperVariableDescription> AnimWrapperVariables
		{
			get
			{
				if (_animWrapperVariables == null)
				{
					_animWrapperVariables = (CArray<animAnimWrapperVariableDescription>) CR2WTypeManager.Create("array:animAnimWrapperVariableDescription", "animWrapperVariables", cr2w, this);
				}
				return _animWrapperVariables;
			}
			set
			{
				if (_animWrapperVariables == value)
				{
					return;
				}
				_animWrapperVariables = value;
				PropertySet(this);
			}
		}

		public animAnimSetCollection(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
