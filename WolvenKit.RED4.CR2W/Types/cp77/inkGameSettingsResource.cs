using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkGameSettingsResource : CResource
	{
		private rRef<inkFullscreenCompositionResource> _compositionResource;
		private CArray<raRef<inkTextureAtlas>> _permanentTextureAtlases;
		private CArray<raRef<inkTextureAtlas>> _permanentTextureAtlasesPC;
		private CArray<raRef<inkTextureAtlas>> _permanentTextureAtlasesDurango;
		private CArray<raRef<inkTextureAtlas>> _permanentTextureAtlasesOrbis;
		private CArray<inkStyleThemeDescriptor> _themes;

		[Ordinal(1)] 
		[RED("compositionResource")] 
		public rRef<inkFullscreenCompositionResource> CompositionResource
		{
			get
			{
				if (_compositionResource == null)
				{
					_compositionResource = (rRef<inkFullscreenCompositionResource>) CR2WTypeManager.Create("rRef:inkFullscreenCompositionResource", "compositionResource", cr2w, this);
				}
				return _compositionResource;
			}
			set
			{
				if (_compositionResource == value)
				{
					return;
				}
				_compositionResource = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("permanentTextureAtlases")] 
		public CArray<raRef<inkTextureAtlas>> PermanentTextureAtlases
		{
			get
			{
				if (_permanentTextureAtlases == null)
				{
					_permanentTextureAtlases = (CArray<raRef<inkTextureAtlas>>) CR2WTypeManager.Create("array:raRef:inkTextureAtlas", "permanentTextureAtlases", cr2w, this);
				}
				return _permanentTextureAtlases;
			}
			set
			{
				if (_permanentTextureAtlases == value)
				{
					return;
				}
				_permanentTextureAtlases = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("permanentTextureAtlasesPC")] 
		public CArray<raRef<inkTextureAtlas>> PermanentTextureAtlasesPC
		{
			get
			{
				if (_permanentTextureAtlasesPC == null)
				{
					_permanentTextureAtlasesPC = (CArray<raRef<inkTextureAtlas>>) CR2WTypeManager.Create("array:raRef:inkTextureAtlas", "permanentTextureAtlasesPC", cr2w, this);
				}
				return _permanentTextureAtlasesPC;
			}
			set
			{
				if (_permanentTextureAtlasesPC == value)
				{
					return;
				}
				_permanentTextureAtlasesPC = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("permanentTextureAtlasesDurango")] 
		public CArray<raRef<inkTextureAtlas>> PermanentTextureAtlasesDurango
		{
			get
			{
				if (_permanentTextureAtlasesDurango == null)
				{
					_permanentTextureAtlasesDurango = (CArray<raRef<inkTextureAtlas>>) CR2WTypeManager.Create("array:raRef:inkTextureAtlas", "permanentTextureAtlasesDurango", cr2w, this);
				}
				return _permanentTextureAtlasesDurango;
			}
			set
			{
				if (_permanentTextureAtlasesDurango == value)
				{
					return;
				}
				_permanentTextureAtlasesDurango = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("permanentTextureAtlasesOrbis")] 
		public CArray<raRef<inkTextureAtlas>> PermanentTextureAtlasesOrbis
		{
			get
			{
				if (_permanentTextureAtlasesOrbis == null)
				{
					_permanentTextureAtlasesOrbis = (CArray<raRef<inkTextureAtlas>>) CR2WTypeManager.Create("array:raRef:inkTextureAtlas", "permanentTextureAtlasesOrbis", cr2w, this);
				}
				return _permanentTextureAtlasesOrbis;
			}
			set
			{
				if (_permanentTextureAtlasesOrbis == value)
				{
					return;
				}
				_permanentTextureAtlasesOrbis = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("themes")] 
		public CArray<inkStyleThemeDescriptor> Themes
		{
			get
			{
				if (_themes == null)
				{
					_themes = (CArray<inkStyleThemeDescriptor>) CR2WTypeManager.Create("array:inkStyleThemeDescriptor", "themes", cr2w, this);
				}
				return _themes;
			}
			set
			{
				if (_themes == value)
				{
					return;
				}
				_themes = value;
				PropertySet(this);
			}
		}

		public inkGameSettingsResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
