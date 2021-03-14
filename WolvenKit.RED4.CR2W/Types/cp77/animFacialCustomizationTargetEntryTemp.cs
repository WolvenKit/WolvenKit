using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animFacialCustomizationTargetEntryTemp : CVariable
	{
		private raRef<animFacialSetup> _setup;
		private CArray<CName> _targetNames;

		[Ordinal(0)] 
		[RED("setup")] 
		public raRef<animFacialSetup> Setup
		{
			get
			{
				if (_setup == null)
				{
					_setup = (raRef<animFacialSetup>) CR2WTypeManager.Create("raRef:animFacialSetup", "setup", cr2w, this);
				}
				return _setup;
			}
			set
			{
				if (_setup == value)
				{
					return;
				}
				_setup = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("targetNames")] 
		public CArray<CName> TargetNames
		{
			get
			{
				if (_targetNames == null)
				{
					_targetNames = (CArray<CName>) CR2WTypeManager.Create("array:CName", "targetNames", cr2w, this);
				}
				return _targetNames;
			}
			set
			{
				if (_targetNames == value)
				{
					return;
				}
				_targetNames = value;
				PropertySet(this);
			}
		}

		public animFacialCustomizationTargetEntryTemp(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
