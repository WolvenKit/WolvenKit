using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questEntityManagerChangeAppearance_NodeType : questIEntityManager_NodeType
	{
		private gameEntityReference _entityRef;
		private CBool _prefetchOnly;
		private CName _appearanceName;

		[Ordinal(0)] 
		[RED("entityRef")] 
		public gameEntityReference EntityRef
		{
			get
			{
				if (_entityRef == null)
				{
					_entityRef = (gameEntityReference) CR2WTypeManager.Create("gameEntityReference", "entityRef", cr2w, this);
				}
				return _entityRef;
			}
			set
			{
				if (_entityRef == value)
				{
					return;
				}
				_entityRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("prefetchOnly")] 
		public CBool PrefetchOnly
		{
			get
			{
				if (_prefetchOnly == null)
				{
					_prefetchOnly = (CBool) CR2WTypeManager.Create("Bool", "prefetchOnly", cr2w, this);
				}
				return _prefetchOnly;
			}
			set
			{
				if (_prefetchOnly == value)
				{
					return;
				}
				_prefetchOnly = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("appearanceName")] 
		public CName AppearanceName
		{
			get
			{
				if (_appearanceName == null)
				{
					_appearanceName = (CName) CR2WTypeManager.Create("CName", "appearanceName", cr2w, this);
				}
				return _appearanceName;
			}
			set
			{
				if (_appearanceName == value)
				{
					return;
				}
				_appearanceName = value;
				PropertySet(this);
			}
		}

		public questEntityManagerChangeAppearance_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
