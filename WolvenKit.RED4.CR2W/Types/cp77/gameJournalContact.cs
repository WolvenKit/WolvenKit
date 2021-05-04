using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameJournalContact : gameJournalFileEntry
	{
		private LocalizationString _name;
		private TweakDBID _avatarID;
		private CEnum<gameContactType> _type;
		private CBool _useFlatMessageLayout;

		[Ordinal(2)] 
		[RED("name")] 
		public LocalizationString Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(3)] 
		[RED("avatarID")] 
		public TweakDBID AvatarID
		{
			get => GetProperty(ref _avatarID);
			set => SetProperty(ref _avatarID, value);
		}

		[Ordinal(4)] 
		[RED("type")] 
		public CEnum<gameContactType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(5)] 
		[RED("useFlatMessageLayout")] 
		public CBool UseFlatMessageLayout
		{
			get => GetProperty(ref _useFlatMessageLayout);
			set => SetProperty(ref _useFlatMessageLayout, value);
		}

		public gameJournalContact(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
