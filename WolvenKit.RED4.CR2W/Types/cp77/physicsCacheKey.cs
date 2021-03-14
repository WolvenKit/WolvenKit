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
			get
			{
				if (_key == null)
				{
					_key = (physicsGeometryKey) CR2WTypeManager.Create("physicsGeometryKey", "key", cr2w, this);
				}
				return _key;
			}
			set
			{
				if (_key == value)
				{
					return;
				}
				_key = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("entryIndex")] 
		public CUInt32 EntryIndex
		{
			get
			{
				if (_entryIndex == null)
				{
					_entryIndex = (CUInt32) CR2WTypeManager.Create("Uint32", "entryIndex", cr2w, this);
				}
				return _entryIndex;
			}
			set
			{
				if (_entryIndex == value)
				{
					return;
				}
				_entryIndex = value;
				PropertySet(this);
			}
		}

		public physicsCacheKey(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
