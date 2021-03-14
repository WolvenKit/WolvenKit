using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animOverrideAnimSetRef : CVariable
	{
		private raRef<animAnimSet> _animSet;
		private CName _variableName;

		[Ordinal(0)] 
		[RED("animSet")] 
		public raRef<animAnimSet> AnimSet
		{
			get
			{
				if (_animSet == null)
				{
					_animSet = (raRef<animAnimSet>) CR2WTypeManager.Create("raRef:animAnimSet", "animSet", cr2w, this);
				}
				return _animSet;
			}
			set
			{
				if (_animSet == value)
				{
					return;
				}
				_animSet = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("variableName")] 
		public CName VariableName
		{
			get
			{
				if (_variableName == null)
				{
					_variableName = (CName) CR2WTypeManager.Create("CName", "variableName", cr2w, this);
				}
				return _variableName;
			}
			set
			{
				if (_variableName == value)
				{
					return;
				}
				_variableName = value;
				PropertySet(this);
			}
		}

		public animOverrideAnimSetRef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
