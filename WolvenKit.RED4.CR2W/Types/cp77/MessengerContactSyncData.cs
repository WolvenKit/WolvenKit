using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MessengerContactSyncData : IScriptable
	{
		private CEnum<MessengerContactType> _type;
		private CInt32 _entryHash;
		private CInt32 _level;

		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<MessengerContactType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(1)] 
		[RED("entryHash")] 
		public CInt32 EntryHash
		{
			get => GetProperty(ref _entryHash);
			set => SetProperty(ref _entryHash, value);
		}

		[Ordinal(2)] 
		[RED("level")] 
		public CInt32 Level
		{
			get => GetProperty(ref _level);
			set => SetProperty(ref _level, value);
		}

		public MessengerContactSyncData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
