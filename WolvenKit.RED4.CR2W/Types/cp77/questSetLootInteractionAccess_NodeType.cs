using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questSetLootInteractionAccess_NodeType : questIItemManagerNodeType
	{
		private gameEntityReference _objectRef;
		private CBool _accessible;

		[Ordinal(0)] 
		[RED("objectRef")] 
		public gameEntityReference ObjectRef
		{
			get => GetProperty(ref _objectRef);
			set => SetProperty(ref _objectRef, value);
		}

		[Ordinal(1)] 
		[RED("accessible")] 
		public CBool Accessible
		{
			get => GetProperty(ref _accessible);
			set => SetProperty(ref _accessible, value);
		}

		public questSetLootInteractionAccess_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
