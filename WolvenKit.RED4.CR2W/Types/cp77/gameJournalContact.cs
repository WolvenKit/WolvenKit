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
			get
			{
				if (_name == null)
				{
					_name = (LocalizationString) CR2WTypeManager.Create("LocalizationString", "name", cr2w, this);
				}
				return _name;
			}
			set
			{
				if (_name == value)
				{
					return;
				}
				_name = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("avatarID")] 
		public TweakDBID AvatarID
		{
			get
			{
				if (_avatarID == null)
				{
					_avatarID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "avatarID", cr2w, this);
				}
				return _avatarID;
			}
			set
			{
				if (_avatarID == value)
				{
					return;
				}
				_avatarID = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("type")] 
		public CEnum<gameContactType> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CEnum<gameContactType>) CR2WTypeManager.Create("gameContactType", "type", cr2w, this);
				}
				return _type;
			}
			set
			{
				if (_type == value)
				{
					return;
				}
				_type = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("useFlatMessageLayout")] 
		public CBool UseFlatMessageLayout
		{
			get
			{
				if (_useFlatMessageLayout == null)
				{
					_useFlatMessageLayout = (CBool) CR2WTypeManager.Create("Bool", "useFlatMessageLayout", cr2w, this);
				}
				return _useFlatMessageLayout;
			}
			set
			{
				if (_useFlatMessageLayout == value)
				{
					return;
				}
				_useFlatMessageLayout = value;
				PropertySet(this);
			}
		}

		public gameJournalContact(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
