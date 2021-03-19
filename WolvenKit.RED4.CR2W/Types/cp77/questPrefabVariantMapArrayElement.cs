using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questPrefabVariantMapArrayElement : CVariable
	{
		private worldGlobalNodeRef _globalNodeRef;
		private CArray<questPrefabVariantReplicatedInfo> _prefabVariantsReplicatedInfos;

		[Ordinal(0)] 
		[RED("globalNodeRef")] 
		public worldGlobalNodeRef GlobalNodeRef
		{
			get => GetProperty(ref _globalNodeRef);
			set => SetProperty(ref _globalNodeRef, value);
		}

		[Ordinal(1)] 
		[RED("PrefabVariantsReplicatedInfos")] 
		public CArray<questPrefabVariantReplicatedInfo> PrefabVariantsReplicatedInfos
		{
			get => GetProperty(ref _prefabVariantsReplicatedInfos);
			set => SetProperty(ref _prefabVariantsReplicatedInfos, value);
		}

		public questPrefabVariantMapArrayElement(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
