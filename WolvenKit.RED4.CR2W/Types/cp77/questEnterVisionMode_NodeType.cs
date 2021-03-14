using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questEnterVisionMode_NodeType : questIVisionModeNodeType
	{
		private gameEntityReference _objectRef;
		private CEnum<gameVisionModeType> _visionModeType;

		[Ordinal(0)] 
		[RED("objectRef")] 
		public gameEntityReference ObjectRef
		{
			get
			{
				if (_objectRef == null)
				{
					_objectRef = (gameEntityReference) CR2WTypeManager.Create("gameEntityReference", "objectRef", cr2w, this);
				}
				return _objectRef;
			}
			set
			{
				if (_objectRef == value)
				{
					return;
				}
				_objectRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("visionModeType")] 
		public CEnum<gameVisionModeType> VisionModeType
		{
			get
			{
				if (_visionModeType == null)
				{
					_visionModeType = (CEnum<gameVisionModeType>) CR2WTypeManager.Create("gameVisionModeType", "visionModeType", cr2w, this);
				}
				return _visionModeType;
			}
			set
			{
				if (_visionModeType == value)
				{
					return;
				}
				_visionModeType = value;
				PropertySet(this);
			}
		}

		public questEnterVisionMode_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
