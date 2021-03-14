using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkWindowDrawMetrics : CVariable
	{
		private CArray<Vector2> _allTextures;
		private CArray<Vector2> _textureSizeTypes;
		private CArray<CUInt32> _textureTypeTotal;
		private CArray<CUInt32> _maxUsedTextureTypes;
		private CArray<inkSingleDrawMetric> _drawMetrics;

		[Ordinal(0)] 
		[RED("allTextures")] 
		public CArray<Vector2> AllTextures
		{
			get
			{
				if (_allTextures == null)
				{
					_allTextures = (CArray<Vector2>) CR2WTypeManager.Create("array:Vector2", "allTextures", cr2w, this);
				}
				return _allTextures;
			}
			set
			{
				if (_allTextures == value)
				{
					return;
				}
				_allTextures = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("textureSizeTypes")] 
		public CArray<Vector2> TextureSizeTypes
		{
			get
			{
				if (_textureSizeTypes == null)
				{
					_textureSizeTypes = (CArray<Vector2>) CR2WTypeManager.Create("array:Vector2", "textureSizeTypes", cr2w, this);
				}
				return _textureSizeTypes;
			}
			set
			{
				if (_textureSizeTypes == value)
				{
					return;
				}
				_textureSizeTypes = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("textureTypeTotal")] 
		public CArray<CUInt32> TextureTypeTotal
		{
			get
			{
				if (_textureTypeTotal == null)
				{
					_textureTypeTotal = (CArray<CUInt32>) CR2WTypeManager.Create("array:Uint32", "textureTypeTotal", cr2w, this);
				}
				return _textureTypeTotal;
			}
			set
			{
				if (_textureTypeTotal == value)
				{
					return;
				}
				_textureTypeTotal = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("maxUsedTextureTypes")] 
		public CArray<CUInt32> MaxUsedTextureTypes
		{
			get
			{
				if (_maxUsedTextureTypes == null)
				{
					_maxUsedTextureTypes = (CArray<CUInt32>) CR2WTypeManager.Create("array:Uint32", "maxUsedTextureTypes", cr2w, this);
				}
				return _maxUsedTextureTypes;
			}
			set
			{
				if (_maxUsedTextureTypes == value)
				{
					return;
				}
				_maxUsedTextureTypes = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("drawMetrics")] 
		public CArray<inkSingleDrawMetric> DrawMetrics
		{
			get
			{
				if (_drawMetrics == null)
				{
					_drawMetrics = (CArray<inkSingleDrawMetric>) CR2WTypeManager.Create("array:inkSingleDrawMetric", "drawMetrics", cr2w, this);
				}
				return _drawMetrics;
			}
			set
			{
				if (_drawMetrics == value)
				{
					return;
				}
				_drawMetrics = value;
				PropertySet(this);
			}
		}

		public inkWindowDrawMetrics(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
