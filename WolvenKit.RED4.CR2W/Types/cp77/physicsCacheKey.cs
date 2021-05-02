using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class physicsCacheKey : CVariable
	{
		private physicsGeometryKey _key;
		private CUInt32 _entryIndex;

		[Ordinal(0)] 
		[RED("key")] 
		public physicsGeometryKey Key
		{
			get => GetProperty(ref _key);
			set => SetProperty(ref _key, value);
		}

		[Ordinal(1)] 
		[RED("entryIndex")] 
		public CUInt32 EntryIndex
		{
			get => GetProperty(ref _entryIndex);
			set => SetProperty(ref _entryIndex, value);
		}

		public physicsCacheKey(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
