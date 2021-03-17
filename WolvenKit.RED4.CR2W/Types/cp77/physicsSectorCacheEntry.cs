using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class physicsSectorCacheEntry : CVariable
	{
		private CUInt32 _entryOffset;
		private CUInt32 _entrySize;

		[Ordinal(0)] 
		[RED("entryOffset")] 
		public CUInt32 EntryOffset
		{
			get => GetProperty(ref _entryOffset);
			set => SetProperty(ref _entryOffset, value);
		}

		[Ordinal(1)] 
		[RED("entrySize")] 
		public CUInt32 EntrySize
		{
			get => GetProperty(ref _entrySize);
			set => SetProperty(ref _entrySize, value);
		}

		public physicsSectorCacheEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
