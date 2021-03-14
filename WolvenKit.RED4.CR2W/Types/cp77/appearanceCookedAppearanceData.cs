using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class appearanceCookedAppearanceData : CResource
	{
		private CArray<rRef<CResource>> _dependencies;
		private CUInt32 _totalSizeOnDisk;

		[Ordinal(1)] 
		[RED("dependencies")] 
		public CArray<rRef<CResource>> Dependencies
		{
			get
			{
				if (_dependencies == null)
				{
					_dependencies = (CArray<rRef<CResource>>) CR2WTypeManager.Create("array:rRef:CResource", "dependencies", cr2w, this);
				}
				return _dependencies;
			}
			set
			{
				if (_dependencies == value)
				{
					return;
				}
				_dependencies = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("totalSizeOnDisk")] 
		public CUInt32 TotalSizeOnDisk
		{
			get
			{
				if (_totalSizeOnDisk == null)
				{
					_totalSizeOnDisk = (CUInt32) CR2WTypeManager.Create("Uint32", "totalSizeOnDisk", cr2w, this);
				}
				return _totalSizeOnDisk;
			}
			set
			{
				if (_totalSizeOnDisk == value)
				{
					return;
				}
				_totalSizeOnDisk = value;
				PropertySet(this);
			}
		}

		public appearanceCookedAppearanceData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
