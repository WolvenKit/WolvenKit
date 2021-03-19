using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questMinimize_NodeType : questIPhoneManagerNodeType
	{
		private CBool _minimize;

		[Ordinal(0)] 
		[RED("minimize")] 
		public CBool Minimize
		{
			get => GetProperty(ref _minimize);
			set => SetProperty(ref _minimize, value);
		}

		public questMinimize_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
