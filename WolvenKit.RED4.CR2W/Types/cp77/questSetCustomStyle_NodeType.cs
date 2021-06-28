using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questSetCustomStyle_NodeType : questIPhoneManagerNodeType
	{
		private CEnum<questCustomStyle> _style;
		private CBool _isActive;

		[Ordinal(0)] 
		[RED("style")] 
		public CEnum<questCustomStyle> Style
		{
			get => GetProperty(ref _style);
			set => SetProperty(ref _style, value);
		}

		[Ordinal(1)] 
		[RED("isActive")] 
		public CBool IsActive
		{
			get => GetProperty(ref _isActive);
			set => SetProperty(ref _isActive, value);
		}

		public questSetCustomStyle_NodeType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
