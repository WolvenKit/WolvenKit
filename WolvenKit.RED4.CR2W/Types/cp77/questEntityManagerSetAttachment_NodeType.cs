using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questEntityManagerSetAttachment_NodeType : questIEntityManager_NodeType
	{
		private CHandle<questIEntityManagerSetAttachment_NodeSubType> _subtype;

		[Ordinal(0)] 
		[RED("subtype")] 
		public CHandle<questIEntityManagerSetAttachment_NodeSubType> Subtype
		{
			get => GetProperty(ref _subtype);
			set => SetProperty(ref _subtype, value);
		}

		public questEntityManagerSetAttachment_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
