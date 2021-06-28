using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questContentTokenManager_NodeType : questIGameManagerNonSignalStoppingNodeType
	{
		private CHandle<questIContentTokenManager_NodeSubType> _subtype;

		[Ordinal(0)] 
		[RED("subtype")] 
		public CHandle<questIContentTokenManager_NodeSubType> Subtype
		{
			get => GetProperty(ref _subtype);
			set => SetProperty(ref _subtype, value);
		}

		public questContentTokenManager_NodeType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
