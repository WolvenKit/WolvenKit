using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnBraindanceLayer_ConditionType : scnIBraindanceConditionType
	{
		private CEnum<scnBraindanceLayer> _layer;
		private raRef<scnSceneResource> _sceneFile;

		[Ordinal(0)] 
		[RED("layer")] 
		public CEnum<scnBraindanceLayer> Layer
		{
			get
			{
				if (_layer == null)
				{
					_layer = (CEnum<scnBraindanceLayer>) CR2WTypeManager.Create("scnBraindanceLayer", "layer", cr2w, this);
				}
				return _layer;
			}
			set
			{
				if (_layer == value)
				{
					return;
				}
				_layer = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("sceneFile")] 
		public raRef<scnSceneResource> SceneFile
		{
			get
			{
				if (_sceneFile == null)
				{
					_sceneFile = (raRef<scnSceneResource>) CR2WTypeManager.Create("raRef:scnSceneResource", "sceneFile", cr2w, this);
				}
				return _sceneFile;
			}
			set
			{
				if (_sceneFile == value)
				{
					return;
				}
				_sceneFile = value;
				PropertySet(this);
			}
		}

		public scnBraindanceLayer_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
