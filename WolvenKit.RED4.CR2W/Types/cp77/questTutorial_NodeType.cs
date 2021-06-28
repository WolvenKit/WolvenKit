using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questTutorial_NodeType : questIUIManagerNodeType
	{
		private CHandle<questITutorial_NodeSubType> _subtype;

		[Ordinal(0)] 
		[RED("subtype")] 
		public CHandle<questITutorial_NodeSubType> Subtype
		{
			get => GetProperty(ref _subtype);
			set => SetProperty(ref _subtype, value);
		}

		public questTutorial_NodeType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
