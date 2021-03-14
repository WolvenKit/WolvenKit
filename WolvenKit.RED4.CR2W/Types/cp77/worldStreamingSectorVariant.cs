using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldStreamingSectorVariant : CVariable
	{
		private NodeRef _nodeRef;
		private CUInt32 _variantId;
		private CUInt32 _parentVariantID;
		private CName _name;
		private CUInt32 _rangeIndex;
		private CBool _enabledByDefault;

		[Ordinal(0)] 
		[RED("nodeRef")] 
		public NodeRef NodeRef
		{
			get
			{
				if (_nodeRef == null)
				{
					_nodeRef = (NodeRef) CR2WTypeManager.Create("NodeRef", "nodeRef", cr2w, this);
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
		[RED("variantId")] 
		public CUInt32 VariantId
		{
			get
			{
				if (_variantId == null)
				{
					_variantId = (CUInt32) CR2WTypeManager.Create("Uint32", "variantId", cr2w, this);
				}
				return _variantId;
			}
			set
			{
				if (_variantId == value)
				{
					return;
				}
				_variantId = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("parentVariantID")] 
		public CUInt32 ParentVariantID
		{
			get
			{
				if (_parentVariantID == null)
				{
					_parentVariantID = (CUInt32) CR2WTypeManager.Create("Uint32", "parentVariantID", cr2w, this);
				}
				return _parentVariantID;
			}
			set
			{
				if (_parentVariantID == value)
				{
					return;
				}
				_parentVariantID = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("name")] 
		public CName Name
		{
			get
			{
				if (_name == null)
				{
					_name = (CName) CR2WTypeManager.Create("CName", "name", cr2w, this);
				}
				return _name;
			}
			set
			{
				if (_name == value)
				{
					return;
				}
				_name = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("rangeIndex")] 
		public CUInt32 RangeIndex
		{
			get
			{
				if (_rangeIndex == null)
				{
					_rangeIndex = (CUInt32) CR2WTypeManager.Create("Uint32", "rangeIndex", cr2w, this);
				}
				return _rangeIndex;
			}
			set
			{
				if (_rangeIndex == value)
				{
					return;
				}
				_rangeIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("enabledByDefault")] 
		public CBool EnabledByDefault
		{
			get
			{
				if (_enabledByDefault == null)
				{
					_enabledByDefault = (CBool) CR2WTypeManager.Create("Bool", "enabledByDefault", cr2w, this);
				}
				return _enabledByDefault;
			}
			set
			{
				if (_enabledByDefault == value)
				{
					return;
				}
				_enabledByDefault = value;
				PropertySet(this);
			}
		}

		public worldStreamingSectorVariant(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
