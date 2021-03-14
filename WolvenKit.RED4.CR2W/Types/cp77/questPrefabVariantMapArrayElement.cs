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
			get
			{
				if (_globalNodeRef == null)
				{
					_globalNodeRef = (worldGlobalNodeRef) CR2WTypeManager.Create("worldGlobalNodeRef", "globalNodeRef", cr2w, this);
				}
				return _globalNodeRef;
			}
			set
			{
				if (_globalNodeRef == value)
				{
					return;
				}
				_globalNodeRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("PrefabVariantsReplicatedInfos")] 
		public CArray<questPrefabVariantReplicatedInfo> PrefabVariantsReplicatedInfos
		{
			get
			{
				if (_prefabVariantsReplicatedInfos == null)
				{
					_prefabVariantsReplicatedInfos = (CArray<questPrefabVariantReplicatedInfo>) CR2WTypeManager.Create("array:questPrefabVariantReplicatedInfo", "PrefabVariantsReplicatedInfos", cr2w, this);
				}
				return _prefabVariantsReplicatedInfos;
			}
			set
			{
				if (_prefabVariantsReplicatedInfos == value)
				{
					return;
				}
				_prefabVariantsReplicatedInfos = value;
				PropertySet(this);
			}
		}

		public questPrefabVariantMapArrayElement(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
