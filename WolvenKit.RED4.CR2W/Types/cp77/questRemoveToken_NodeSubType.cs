using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questRemoveToken_NodeSubType : questIContentTokenManager_NodeSubType
	{
		private CBool _removeAll;

		[Ordinal(0)] 
		[RED("removeAll")] 
		public CBool RemoveAll
		{
			get => GetProperty(ref _removeAll);
			set => SetProperty(ref _removeAll, value);
		}

		public questRemoveToken_NodeSubType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
