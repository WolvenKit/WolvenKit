using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BuildButtonItemController : inkButtonDpadSupportedController
	{
		private CEnum<gamedataBuildType> _associatedBuild;

		[Ordinal(26)] 
		[RED("associatedBuild")] 
		public CEnum<gamedataBuildType> AssociatedBuild
		{
			get
			{
				if (_associatedBuild == null)
				{
					_associatedBuild = (CEnum<gamedataBuildType>) CR2WTypeManager.Create("gamedataBuildType", "associatedBuild", cr2w, this);
				}
				return _associatedBuild;
			}
			set
			{
				if (_associatedBuild == value)
				{
					return;
				}
				_associatedBuild = value;
				PropertySet(this);
			}
		}

		public BuildButtonItemController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
