using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnInterestingConversation_DEPRECATED : CVariable
	{
		private raRef<scnSceneResource> _sceneFilename;

		[Ordinal(0)] 
		[RED("sceneFilename")] 
		public raRef<scnSceneResource> SceneFilename
		{
			get
			{
				if (_sceneFilename == null)
				{
					_sceneFilename = (raRef<scnSceneResource>) CR2WTypeManager.Create("raRef:scnSceneResource", "sceneFilename", cr2w, this);
				}
				return _sceneFilename;
			}
			set
			{
				if (_sceneFilename == value)
				{
					return;
				}
				_sceneFilename = value;
				PropertySet(this);
			}
		}

		public scnInterestingConversation_DEPRECATED(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
