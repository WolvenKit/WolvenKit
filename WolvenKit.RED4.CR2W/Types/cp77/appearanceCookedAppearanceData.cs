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
			get => GetProperty(ref _dependencies);
			set => SetProperty(ref _dependencies, value);
		}

		[Ordinal(2)] 
		[RED("totalSizeOnDisk")] 
		public CUInt32 TotalSizeOnDisk
		{
			get => GetProperty(ref _totalSizeOnDisk);
			set => SetProperty(ref _totalSizeOnDisk, value);
		}

		public appearanceCookedAppearanceData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
