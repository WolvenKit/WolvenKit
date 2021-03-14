using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questSceneLocation : CVariable
	{
		private CName _sceneWorldMarkerTag;

		[Ordinal(0)] 
		[RED("sceneWorldMarkerTag")] 
		public CName SceneWorldMarkerTag
		{
			get
			{
				if (_sceneWorldMarkerTag == null)
				{
					_sceneWorldMarkerTag = (CName) CR2WTypeManager.Create("CName", "sceneWorldMarkerTag", cr2w, this);
				}
				return _sceneWorldMarkerTag;
			}
			set
			{
				if (_sceneWorldMarkerTag == value)
				{
					return;
				}
				_sceneWorldMarkerTag = value;
				PropertySet(this);
			}
		}

		public questSceneLocation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
