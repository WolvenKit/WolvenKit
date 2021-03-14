using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnAnimSetDynAnimNames : CVariable
	{
		private CStatic<CName> _animVariable;
		private CArray<CName> _animNames;

		[Ordinal(0)] 
		[RED("animVariable", 1)] 
		public CStatic<CName> AnimVariable
		{
			get
			{
				if (_animVariable == null)
				{
					_animVariable = (CStatic<CName>) CR2WTypeManager.Create("static:1,CName", "animVariable", cr2w, this);
				}
				return _animVariable;
			}
			set
			{
				if (_animVariable == value)
				{
					return;
				}
				_animVariable = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("animNames")] 
		public CArray<CName> AnimNames
		{
			get
			{
				if (_animNames == null)
				{
					_animNames = (CArray<CName>) CR2WTypeManager.Create("array:CName", "animNames", cr2w, this);
				}
				return _animNames;
			}
			set
			{
				if (_animNames == value)
				{
					return;
				}
				_animNames = value;
				PropertySet(this);
			}
		}

		public scnAnimSetDynAnimNames(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
