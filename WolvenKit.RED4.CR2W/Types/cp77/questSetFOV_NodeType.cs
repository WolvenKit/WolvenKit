using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questSetFOV_NodeType : questISceneManagerNodeType
	{
		private CFloat _fOV;

		[Ordinal(0)] 
		[RED("FOV")] 
		public CFloat FOV
		{
			get => GetProperty(ref _fOV);
			set => SetProperty(ref _fOV, value);
		}

		public questSetFOV_NodeType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
