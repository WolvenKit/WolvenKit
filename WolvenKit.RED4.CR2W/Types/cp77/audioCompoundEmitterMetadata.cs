using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioCompoundEmitterMetadata : audioEmitterMetadata
	{
		private CArray<CName> _childrenNames;

		[Ordinal(1)] 
		[RED("childrenNames")] 
		public CArray<CName> ChildrenNames
		{
			get
			{
				if (_childrenNames == null)
				{
					_childrenNames = (CArray<CName>) CR2WTypeManager.Create("array:CName", "childrenNames", cr2w, this);
				}
				return _childrenNames;
			}
			set
			{
				if (_childrenNames == value)
				{
					return;
				}
				_childrenNames = value;
				PropertySet(this);
			}
		}

		public audioCompoundEmitterMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
