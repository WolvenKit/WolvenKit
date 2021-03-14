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
			get
			{
				if (_textureAtlas == null)
				{
					_textureAtlas = (rRef<inkTextureAtlas>) CR2WTypeManager.Create("rRef:inkTextureAtlas", "textureAtlas", cr2w, this);
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

		[Ordinal(1)] 
		[RED("texturePartId")] 
		public CName TexturePartId
		{
			get
			{
				if (_texturePartId == null)
				{
					_texturePartId = (CName) CR2WTypeManager.Create("CName", "texturePartId", cr2w, this);
				}
				return _texturePartId;
			}
			set
			{
				if (_texturePartId == value)
				{
					return;
				}
				_texturePartId = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("tileType")] 
		public CEnum<inkBrushTileType> TileType
		{
			get
			{
				if (_tileType == null)
				{
					_tileType = (CEnum<inkBrushTileType>) CR2WTypeManager.Create("inkBrushTileType", "tileType", cr2w, this);
				}
				return _tileType;
			}
			set
			{
				if (_tileType == value)
				{
					return;
				}
				_tileType = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("mirrorType")] 
		public CEnum<inkBrushMirrorType> MirrorType
		{
			get
			{
				if (_mirrorType == null)
				{
					_mirrorType = (CEnum<inkBrushMirrorType>) CR2WTypeManager.Create("inkBrushMirrorType", "mirrorType", cr2w, this);
				}
				return _mirrorType;
			}
			set
			{
				if (_mirrorType == value)
				{
					return;
				}
				_mirrorType = value;
				PropertySet(this);
			}
		}

		public inkWidgetBrush(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
