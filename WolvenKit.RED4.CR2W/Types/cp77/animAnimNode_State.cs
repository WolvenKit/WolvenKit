using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_State : animAnimNode_Container
	{
		private CName _name;
		private CArray<CInt16> _outTransitionIndices;
		private CBool _preventTransitionsInActivationFrame;
		private CArray<CName> _tags;
		private CUInt32 _requiredQualityDistanceCategory;

		[Ordinal(12)] 
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

		[Ordinal(13)] 
		[RED("outTransitionIndices")] 
		public CArray<CInt16> OutTransitionIndices
		{
			get
			{
				if (_outTransitionIndices == null)
				{
					_outTransitionIndices = (CArray<CInt16>) CR2WTypeManager.Create("array:Int16", "outTransitionIndices", cr2w, this);
				}
				return _outTransitionIndices;
			}
			set
			{
				if (_outTransitionIndices == value)
				{
					return;
				}
				_outTransitionIndices = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("preventTransitionsInActivationFrame")] 
		public CBool PreventTransitionsInActivationFrame
		{
			get
			{
				if (_preventTransitionsInActivationFrame == null)
				{
					_preventTransitionsInActivationFrame = (CBool) CR2WTypeManager.Create("Bool", "preventTransitionsInActivationFrame", cr2w, this);
				}
				return _preventTransitionsInActivationFrame;
			}
			set
			{
				if (_preventTransitionsInActivationFrame == value)
				{
					return;
				}
				_preventTransitionsInActivationFrame = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("tags")] 
		public CArray<CName> Tags
		{
			get
			{
				if (_tags == null)
				{
					_tags = (CArray<CName>) CR2WTypeManager.Create("array:CName", "tags", cr2w, this);
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

		[Ordinal(16)] 
		[RED("requiredQualityDistanceCategory")] 
		public CUInt32 RequiredQualityDistanceCategory
		{
			get
			{
				if (_requiredQualityDistanceCategory == null)
				{
					_requiredQualityDistanceCategory = (CUInt32) CR2WTypeManager.Create("Uint32", "requiredQualityDistanceCategory", cr2w, this);
				}
				return _requiredQualityDistanceCategory;
			}
			set
			{
				if (_requiredQualityDistanceCategory == value)
				{
					return;
				}
				_requiredQualityDistanceCategory = value;
				PropertySet(this);
			}
		}

		public animAnimNode_State(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
