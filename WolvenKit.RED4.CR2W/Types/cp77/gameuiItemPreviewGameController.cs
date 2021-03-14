using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiItemPreviewGameController : gameuiPreviewGameController
	{
		private CName _sceneName;
		private NodeRef _cameraRef;

		[Ordinal(6)] 
		[RED("sceneName")] 
		public CName SceneName
		{
			get
			{
				if (_sceneName == null)
				{
					_sceneName = (CName) CR2WTypeManager.Create("CName", "sceneName", cr2w, this);
				}
				return _sceneName;
			}
			set
			{
				if (_sceneName == value)
				{
					return;
				}
				_sceneName = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("cameraRef")] 
		public NodeRef CameraRef
		{
			get
			{
				if (_cameraRef == null)
				{
					_cameraRef = (NodeRef) CR2WTypeManager.Create("NodeRef", "cameraRef", cr2w, this);
				}
				return _cameraRef;
			}
			set
			{
				if (_cameraRef == value)
				{
					return;
				}
				_cameraRef = value;
				PropertySet(this);
			}
		}

		public gameuiItemPreviewGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
