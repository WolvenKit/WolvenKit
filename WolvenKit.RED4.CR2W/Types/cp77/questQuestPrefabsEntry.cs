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
			get
			{
				if (_nodeRef == null)
				{
					_nodeRef = (worldGlobalNodeRef) CR2WTypeManager.Create("worldGlobalNodeRef", "nodeRef", cr2w, this);
				}
				return _nodeRef;
			}
			set
			{
				if (_nodeRef == value)
				{
					return;
				}
				_nodeRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("loadingMode")] 
		public CEnum<worldQuestPrefabLoadingMode> LoadingMode
		{
			get
			{
				if (_loadingMode == null)
				{
					_loadingMode = (CEnum<worldQuestPrefabLoadingMode>) CR2WTypeManager.Create("worldQuestPrefabLoadingMode", "loadingMode", cr2w, this);
				}
				return _loadingMode;
			}
			set
			{
				if (_loadingMode == value)
				{
					return;
				}
				_loadingMode = value;
				PropertySet(this);
			}
		}

		public questQuestPrefabsEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
