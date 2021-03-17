using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questQuestPrefabsEntry : CVariable
	{
		private worldGlobalNodeRef _nodeRef;
		private CEnum<worldQuestPrefabLoadingMode> _loadingMode;

		[Ordinal(0)] 
		[RED("nodeRef")] 
		public worldGlobalNodeRef NodeRef
		{
			get => GetProperty(ref _nodeRef);
			set => SetProperty(ref _nodeRef, value);
		}

		[Ordinal(1)] 
		[RED("loadingMode")] 
		public CEnum<worldQuestPrefabLoadingMode> LoadingMode
		{
			get => GetProperty(ref _loadingMode);
			set => SetProperty(ref _loadingMode, value);
		}

		public questQuestPrefabsEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
