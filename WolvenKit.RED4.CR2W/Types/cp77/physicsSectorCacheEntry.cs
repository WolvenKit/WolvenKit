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
			get
			{
				if (_entryOffset == null)
				{
					_entryOffset = (CUInt32) CR2WTypeManager.Create("Uint32", "entryOffset", cr2w, this);
				}
				return _entryOffset;
			}
			set
			{
				if (_entryOffset == value)
				{
					return;
				}
				_entryOffset = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("entrySize")] 
		public CUInt32 EntrySize
		{
			get
			{
				if (_entrySize == null)
				{
					_entrySize = (CUInt32) CR2WTypeManager.Create("Uint32", "entrySize", cr2w, this);
				}
				return _entrySize;
			}
			set
			{
				if (_entrySize == value)
				{
					return;
				}
				_entrySize = value;
				PropertySet(this);
			}
		}

		public physicsSectorCacheEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
