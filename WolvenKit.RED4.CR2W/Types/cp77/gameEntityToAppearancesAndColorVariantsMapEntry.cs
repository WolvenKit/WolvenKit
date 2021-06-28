using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEntityToAppearancesAndColorVariantsMapEntry : ISerializable
	{
		private CUInt64 _entityPathHash;
		private CString _debugEntityPath;
		private CArray<gameEntityAppearanceColorVariantsArray> _appearancesAndTheirColorVariants;

		[Ordinal(0)] 
		[RED("entityPathHash")] 
		public CUInt64 EntityPathHash
		{
			get => GetProperty(ref _entityPathHash);
			set => SetProperty(ref _entityPathHash, value);
		}

		[Ordinal(1)] 
		[RED("debugEntityPath")] 
		public CString DebugEntityPath
		{
			get => GetProperty(ref _debugEntityPath);
			set => SetProperty(ref _debugEntityPath, value);
		}

		[Ordinal(2)] 
		[RED("appearancesAndTheirColorVariants")] 
		public CArray<gameEntityAppearanceColorVariantsArray> AppearancesAndTheirColorVariants
		{
			get => GetProperty(ref _appearancesAndTheirColorVariants);
			set => SetProperty(ref _appearancesAndTheirColorVariants, value);
		}

		public gameEntityToAppearancesAndColorVariantsMapEntry(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
