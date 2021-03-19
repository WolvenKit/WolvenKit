using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkWidgetBrush : IScriptable
	{
		private rRef<inkTextureAtlas> _textureAtlas;
		private CName _texturePartId;
		private CEnum<inkBrushTileType> _tileType;
		private CEnum<inkBrushMirrorType> _mirrorType;

		[Ordinal(0)] 
		[RED("textureAtlas")] 
		public rRef<inkTextureAtlas> TextureAtlas
		{
			get => GetProperty(ref _textureAtlas);
			set => SetProperty(ref _textureAtlas, value);
		}

		[Ordinal(1)] 
		[RED("texturePartId")] 
		public CName TexturePartId
		{
			get => GetProperty(ref _texturePartId);
			set => SetProperty(ref _texturePartId, value);
		}

		[Ordinal(2)] 
		[RED("tileType")] 
		public CEnum<inkBrushTileType> TileType
		{
			get => GetProperty(ref _tileType);
			set => SetProperty(ref _tileType, value);
		}

		[Ordinal(3)] 
		[RED("mirrorType")] 
		public CEnum<inkBrushMirrorType> MirrorType
		{
			get => GetProperty(ref _mirrorType);
			set => SetProperty(ref _mirrorType, value);
		}

		public inkWidgetBrush(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
