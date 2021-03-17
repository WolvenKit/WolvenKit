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
			get => GetProperty(ref _objectRef);
			set => SetProperty(ref _objectRef, value);
		}

		[Ordinal(1)] 
		[RED("visionModeType")] 
		public CEnum<gameVisionModeType> VisionModeType
		{
			get => GetProperty(ref _visionModeType);
			set => SetProperty(ref _visionModeType, value);
		}

		public questEnterVisionMode_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
