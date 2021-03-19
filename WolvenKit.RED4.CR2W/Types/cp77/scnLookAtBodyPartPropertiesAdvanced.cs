using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnLookAtBodyPartPropertiesAdvanced : CVariable
	{
		private CName _bodyPartName;

		[Ordinal(0)] 
		[RED("bodyPartName")] 
		public CName BodyPartName
		{
			get => GetProperty(ref _bodyPartName);
			set => SetProperty(ref _bodyPartName, value);
		}

		public scnLookAtBodyPartPropertiesAdvanced(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
