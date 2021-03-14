using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnAnimSetAnimNames : CVariable
	{
		private CArray<CName> _animationNames;

		[Ordinal(0)] 
		[RED("animationNames")] 
		public CArray<CName> AnimationNames
		{
			get
			{
				if (_animationNames == null)
				{
					_animationNames = (CArray<CName>) CR2WTypeManager.Create("array:CName", "animationNames", cr2w, this);
				}
				return _animationNames;
			}
			set
			{
				if (_animationNames == value)
				{
					return;
				}
				_animationNames = value;
				PropertySet(this);
			}
		}

		public scnAnimSetAnimNames(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
