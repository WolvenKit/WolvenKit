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
			get => GetProperty(ref _compositionResource);
			set => SetProperty(ref _compositionResource, value);
		}

		[Ordinal(2)] 
		[RED("permanentTextureAtlases")] 
		public CArray<raRef<inkTextureAtlas>> PermanentTextureAtlases
		{
			get => GetProperty(ref _permanentTextureAtlases);
			set => SetProperty(ref _permanentTextureAtlases, value);
		}

		[Ordinal(3)] 
		[RED("permanentTextureAtlasesPC")] 
		public CArray<raRef<inkTextureAtlas>> PermanentTextureAtlasesPC
		{
			get => GetProperty(ref _permanentTextureAtlasesPC);
			set => SetProperty(ref _permanentTextureAtlasesPC, value);
		}

		[Ordinal(4)] 
		[RED("permanentTextureAtlasesDurango")] 
		public CArray<raRef<inkTextureAtlas>> PermanentTextureAtlasesDurango
		{
			get => GetProperty(ref _permanentTextureAtlasesDurango);
			set => SetProperty(ref _permanentTextureAtlasesDurango, value);
		}

		[Ordinal(5)] 
		[RED("permanentTextureAtlasesOrbis")] 
		public CArray<raRef<inkTextureAtlas>> PermanentTextureAtlasesOrbis
		{
			get => GetProperty(ref _permanentTextureAtlasesOrbis);
			set => SetProperty(ref _permanentTextureAtlasesOrbis, value);
		}

		[Ordinal(6)] 
		[RED("themes")] 
		public CArray<inkStyleThemeDescriptor> Themes
		{
			get => GetProperty(ref _themes);
			set => SetProperty(ref _themes, value);
		}

		public inkGameSettingsResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
