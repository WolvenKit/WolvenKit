using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questWorldStateSystemReplicatedState : CVariable
	{
		private CArray<questNodeVisibilityMapArrayElement> _nodeVisibilityMapArray;
		private CArray<questIsInMirrorsAreaMapArrayElement> _isInMirrorsAreaMapArray;
		private CArray<questNodeCollisionMapArrayElement> _nodeCollisionMapArray;
		private CArray<questPrefabVariantMapArrayElement> _prefabVariants;

		[Ordinal(0)] 
		[RED("nodeVisibilityMapArray")] 
		public CArray<questNodeVisibilityMapArrayElement> NodeVisibilityMapArray
		{
			get
			{
				if (_nodeVisibilityMapArray == null)
				{
					_nodeVisibilityMapArray = (CArray<questNodeVisibilityMapArrayElement>) CR2WTypeManager.Create("array:questNodeVisibilityMapArrayElement", "nodeVisibilityMapArray", cr2w, this);
				}
				return _nodeVisibilityMapArray;
			}
			set
			{
				if (_nodeVisibilityMapArray == value)
				{
					return;
				}
				_nodeVisibilityMapArray = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("isInMirrorsAreaMapArray")] 
		public CArray<questIsInMirrorsAreaMapArrayElement> IsInMirrorsAreaMapArray
		{
			get
			{
				if (_isInMirrorsAreaMapArray == null)
				{
					_isInMirrorsAreaMapArray = (CArray<questIsInMirrorsAreaMapArrayElement>) CR2WTypeManager.Create("array:questIsInMirrorsAreaMapArrayElement", "isInMirrorsAreaMapArray", cr2w, this);
				}
				return _isInMirrorsAreaMapArray;
			}
			set
			{
				if (_isInMirrorsAreaMapArray == value)
				{
					return;
				}
				_isInMirrorsAreaMapArray = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("nodeCollisionMapArray")] 
		public CArray<questNodeCollisionMapArrayElement> NodeCollisionMapArray
		{
			get
			{
				if (_nodeCollisionMapArray == null)
				{
					_nodeCollisionMapArray = (CArray<questNodeCollisionMapArrayElement>) CR2WTypeManager.Create("array:questNodeCollisionMapArrayElement", "nodeCollisionMapArray", cr2w, this);
				}
				return _nodeCollisionMapArray;
			}
			set
			{
				if (_nodeCollisionMapArray == value)
				{
					return;
				}
				_nodeCollisionMapArray = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("prefabVariants")] 
		public CArray<questPrefabVariantMapArrayElement> PrefabVariants
		{
			get
			{
				if (_prefabVariants == null)
				{
					_prefabVariants = (CArray<questPrefabVariantMapArrayElement>) CR2WTypeManager.Create("array:questPrefabVariantMapArrayElement", "prefabVariants", cr2w, this);
				}
				return _prefabVariants;
			}
			set
			{
				if (_prefabVariants == value)
				{
					return;
				}
				_prefabVariants = value;
				PropertySet(this);
			}
		}

		public questWorldStateSystemReplicatedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
