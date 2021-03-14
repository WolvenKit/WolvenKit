using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class communityPhaseTimePeriod : communityTimePeriod
	{
		private CUInt16 _quantity;
		private CArray<CName> _markings;
		private CArray<NodeRef> _spotNodeRefs;
		private CArray<gameSpotSequenceCategory> _categories;
		private CBool _isSequence;

		[Ordinal(1)] 
		[RED("quantity")] 
		public CUInt16 Quantity
		{
			get
			{
				if (_quantity == null)
				{
					_quantity = (CUInt16) CR2WTypeManager.Create("Uint16", "quantity", cr2w, this);
				}
				return _quantity;
			}
			set
			{
				if (_quantity == value)
				{
					return;
				}
				_quantity = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("markings")] 
		public CArray<CName> Markings
		{
			get
			{
				if (_markings == null)
				{
					_markings = (CArray<CName>) CR2WTypeManager.Create("array:CName", "markings", cr2w, this);
				}
				return _markings;
			}
			set
			{
				if (_markings == value)
				{
					return;
				}
				_markings = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("spotNodeRefs")] 
		public CArray<NodeRef> SpotNodeRefs
		{
			get
			{
				if (_spotNodeRefs == null)
				{
					_spotNodeRefs = (CArray<NodeRef>) CR2WTypeManager.Create("array:NodeRef", "spotNodeRefs", cr2w, this);
				}
				return _spotNodeRefs;
			}
			set
			{
				if (_spotNodeRefs == value)
				{
					return;
				}
				_spotNodeRefs = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("categories")] 
		public CArray<gameSpotSequenceCategory> Categories
		{
			get
			{
				if (_categories == null)
				{
					_categories = (CArray<gameSpotSequenceCategory>) CR2WTypeManager.Create("array:gameSpotSequenceCategory", "categories", cr2w, this);
				}
				return _categories;
			}
			set
			{
				if (_categories == value)
				{
					return;
				}
				_categories = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("isSequence")] 
		public CBool IsSequence
		{
			get
			{
				if (_isSequence == null)
				{
					_isSequence = (CBool) CR2WTypeManager.Create("Bool", "isSequence", cr2w, this);
				}
				return _isSequence;
			}
			set
			{
				if (_isSequence == value)
				{
					return;
				}
				_isSequence = value;
				PropertySet(this);
			}
		}

		public communityPhaseTimePeriod(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
