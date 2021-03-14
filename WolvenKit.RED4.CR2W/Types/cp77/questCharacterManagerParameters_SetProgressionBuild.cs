using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCharacterManagerParameters_SetProgressionBuild : questICharacterManagerParameters_NodeSubType
	{
		private TweakDBID _buildID;

		[Ordinal(0)] 
		[RED("buildID")] 
		public TweakDBID BuildID
		{
			get
			{
				if (_buildID == null)
				{
					_buildID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "buildID", cr2w, this);
				}
				return _buildID;
			}
			set
			{
				if (_buildID == value)
				{
					return;
				}
				_buildID = value;
				PropertySet(this);
			}
		}

		public questCharacterManagerParameters_SetProgressionBuild(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
