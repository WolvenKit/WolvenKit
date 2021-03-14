using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameJournalInternetSite : gameJournalFileEntry
	{
		private LocalizationString _shortName;
		private CHandle<gameJournalPath> _mainPagePath;
		private CBool _ignoredAtDesktop;
		private raRef<inkTextureAtlas> _textureAtlas;
		private CName _texturePart;

		[Ordinal(2)] 
		[RED("shortName")] 
		public LocalizationString ShortName
		{
			get
			{
				if (_shortName == null)
				{
					_shortName = (LocalizationString) CR2WTypeManager.Create("LocalizationString", "shortName", cr2w, this);
				}
				return _shortName;
			}
			set
			{
				if (_shortName == value)
				{
					return;
				}
				_shortName = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("mainPagePath")] 
		public CHandle<gameJournalPath> MainPagePath
		{
			get
			{
				if (_mainPagePath == null)
				{
					_mainPagePath = (CHandle<gameJournalPath>) CR2WTypeManager.Create("handle:gameJournalPath", "mainPagePath", cr2w, this);
				}
				return _mainPagePath;
			}
			set
			{
				if (_mainPagePath == value)
				{
					return;
				}
				_mainPagePath = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("ignoredAtDesktop")] 
		public CBool IgnoredAtDesktop
		{
			get
			{
				if (_ignoredAtDesktop == null)
				{
					_ignoredAtDesktop = (CBool) CR2WTypeManager.Create("Bool", "ignoredAtDesktop", cr2w, this);
				}
				return _ignoredAtDesktop;
			}
			set
			{
				if (_ignoredAtDesktop == value)
				{
					return;
				}
				_ignoredAtDesktop = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("textureAtlas")] 
		public raRef<inkTextureAtlas> TextureAtlas
		{
			get
			{
				if (_textureAtlas == null)
				{
					_textureAtlas = (raRef<inkTextureAtlas>) CR2WTypeManager.Create("raRef:inkTextureAtlas", "textureAtlas", cr2w, this);
				}
				return _textureAtlas;
			}
			set
			{
				if (_textureAtlas == value)
				{
					return;
				}
				_textureAtlas = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("texturePart")] 
		public CName TexturePart
		{
			get
			{
				if (_texturePart == null)
				{
					_texturePart = (CName) CR2WTypeManager.Create("CName", "texturePart", cr2w, this);
				}
				return _texturePart;
			}
			set
			{
				if (_texturePart == value)
				{
					return;
				}
				_texturePart = value;
				PropertySet(this);
			}
		}

		public gameJournalInternetSite(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
