using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetProgressionBuild : gamePlayerScriptableSystemRequest
	{
		private CEnum<gamedataBuildType> _buildType;

		[Ordinal(1)] 
		[RED("buildType")] 
		public CEnum<gamedataBuildType> BuildType
		{
			get
			{
				if (_buildType == null)
				{
					_buildType = (CEnum<gamedataBuildType>) CR2WTypeManager.Create("gamedataBuildType", "buildType", cr2w, this);
				}
				return _buildType;
			}
			set
			{
				if (_buildType == value)
				{
					return;
				}
				_buildType = value;
				PropertySet(this);
			}
		}

		public SetProgressionBuild(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
