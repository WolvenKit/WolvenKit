using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldRelativeNodePath : CVariable
	{
		private CUInt32 _parentsToSkip;
		private CArray<worldRelativeNodePathElement> _elements;

		[Ordinal(0)] 
		[RED("parentsToSkip")] 
		public CUInt32 ParentsToSkip
		{
			get
			{
				if (_parentsToSkip == null)
				{
					_parentsToSkip = (CUInt32) CR2WTypeManager.Create("Uint32", "parentsToSkip", cr2w, this);
				}
				return _parentsToSkip;
			}
			set
			{
				if (_parentsToSkip == value)
				{
					return;
				}
				_parentsToSkip = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("elements")] 
		public CArray<worldRelativeNodePathElement> Elements
		{
			get
			{
				if (_elements == null)
				{
					_elements = (CArray<worldRelativeNodePathElement>) CR2WTypeManager.Create("array:worldRelativeNodePathElement", "elements", cr2w, this);
				}
				return _elements;
			}
			set
			{
				if (_elements == value)
				{
					return;
				}
				_elements = value;
				PropertySet(this);
			}
		}

		public worldRelativeNodePath(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
