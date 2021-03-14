using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class meshMeshParamWorkspotOffsets : meshMeshParameter
	{
		private CArray<CName> _names;
		private CArray<CMatrix> _offsets;

		[Ordinal(0)] 
		[RED("names")] 
		public CArray<CName> Names
		{
			get
			{
				if (_names == null)
				{
					_names = (CArray<CName>) CR2WTypeManager.Create("array:CName", "names", cr2w, this);
				}
				return _names;
			}
			set
			{
				if (_names == value)
				{
					return;
				}
				_names = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("offsets")] 
		public CArray<CMatrix> Offsets
		{
			get
			{
				if (_offsets == null)
				{
					_offsets = (CArray<CMatrix>) CR2WTypeManager.Create("array:Matrix", "offsets", cr2w, this);
				}
				return _offsets;
			}
			set
			{
				if (_offsets == value)
				{
					return;
				}
				_offsets = value;
				PropertySet(this);
			}
		}

		public meshMeshParamWorkspotOffsets(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
