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
			get
			{
				if (_bodyPartName == null)
				{
					_bodyPartName = (CName) CR2WTypeManager.Create("CName", "bodyPartName", cr2w, this);
				}
				return _bodyPartName;
			}
			set
			{
				if (_bodyPartName == value)
				{
					return;
				}
				_bodyPartName = value;
				PropertySet(this);
			}
		}

		public scnLookAtBodyPartPropertiesAdvanced(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
