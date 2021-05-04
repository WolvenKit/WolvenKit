using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuestListHeaderData : IScriptable
	{
		private CInt32 _type;
		private CName _nameLocKey;

		[Ordinal(0)] 
		[RED("type")] 
		public CInt32 Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(1)] 
		[RED("nameLocKey")] 
		public CName NameLocKey
		{
			get => GetProperty(ref _nameLocKey);
			set => SetProperty(ref _nameLocKey, value);
		}

		public QuestListHeaderData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
