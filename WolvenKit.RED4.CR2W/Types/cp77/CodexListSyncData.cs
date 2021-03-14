using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CodexListSyncData : IScriptable
	{
		private CInt32 _entryHash;
		private CInt32 _level;

		[Ordinal(0)] 
		[RED("entryHash")] 
		public CInt32 EntryHash
		{
			get
			{
				if (_entryHash == null)
				{
					_entryHash = (CInt32) CR2WTypeManager.Create("Int32", "entryHash", cr2w, this);
				}
				return _entryHash;
			}
			set
			{
				if (_entryHash == value)
				{
					return;
				}
				_entryHash = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("level")] 
		public CInt32 Level
		{
			get
			{
				if (_level == null)
				{
					_level = (CInt32) CR2WTypeManager.Create("Int32", "level", cr2w, this);
				}
				return _level;
			}
			set
			{
				if (_level == value)
				{
					return;
				}
				_level = value;
				PropertySet(this);
			}
		}

		public CodexListSyncData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
