using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questSetItemTags_NodeTypeParams : CVariable
	{
		private CHandle<questUniversalRef> _objectRef;
		private TweakDBID _itemId;
		private CBool _addTags;
		private CEnum<gameEItemDynamicTags> _tags;

		[Ordinal(0)] 
		[RED("objectRef")] 
		public CHandle<questUniversalRef> ObjectRef
		{
			get
			{
				if (_objectRef == null)
				{
					_objectRef = (CHandle<questUniversalRef>) CR2WTypeManager.Create("handle:questUniversalRef", "objectRef", cr2w, this);
				}
				return _objectRef;
			}
			set
			{
				if (_objectRef == value)
				{
					return;
				}
				_objectRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("itemId")] 
		public TweakDBID ItemId
		{
			get
			{
				if (_itemId == null)
				{
					_itemId = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "itemId", cr2w, this);
				}
				return _itemId;
			}
			set
			{
				if (_itemId == value)
				{
					return;
				}
				_itemId = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("addTags")] 
		public CBool AddTags
		{
			get
			{
				if (_addTags == null)
				{
					_addTags = (CBool) CR2WTypeManager.Create("Bool", "addTags", cr2w, this);
				}
				return _addTags;
			}
			set
			{
				if (_addTags == value)
				{
					return;
				}
				_addTags = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("tags")] 
		public CEnum<gameEItemDynamicTags> Tags
		{
			get
			{
				if (_tags == null)
				{
					_tags = (CEnum<gameEItemDynamicTags>) CR2WTypeManager.Create("gameEItemDynamicTags", "tags", cr2w, this);
				}
				return _tags;
			}
			set
			{
				if (_tags == value)
				{
					return;
				}
				_tags = value;
				PropertySet(this);
			}
		}

		public questSetItemTags_NodeTypeParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
