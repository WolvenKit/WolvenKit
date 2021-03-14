using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkTextureAtlas : CResource
	{
		private CEnum<inkTextureType> _activeTexture;
		private CEnum<inkETextureResolution> _textureResolution;
		private raRef<CBitmapTexture> _texture;
		private raRef<DynamicTexture> _dynamicTexture;
		private CArray<inkTextureAtlasMapper> _parts;
		private CArray<inkTextureAtlasSlice> _slices;
		private CArrayFixedSize<inkTextureSlot> _slots;
		private inkDynamicTextureSlot _dynamicTextureSlot;
		private CBool _isSingleTextureMode;

		[Ordinal(1)] 
		[RED("activeTexture")] 
		public CEnum<inkTextureType> ActiveTexture
		{
			get
			{
				if (_activeTexture == null)
				{
					_activeTexture = (CEnum<inkTextureType>) CR2WTypeManager.Create("inkTextureType", "activeTexture", cr2w, this);
				}
				return _activeTexture;
			}
			set
			{
				if (_activeTexture == value)
				{
					return;
				}
				_activeTexture = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("textureResolution")] 
		public CEnum<inkETextureResolution> TextureResolution
		{
			get
			{
				if (_textureResolution == null)
				{
					_textureResolution = (CEnum<inkETextureResolution>) CR2WTypeManager.Create("inkETextureResolution", "textureResolution", cr2w, this);
				}
				return _textureResolution;
			}
			set
			{
				if (_textureResolution == value)
				{
					return;
				}
				_textureResolution = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("texture")] 
		public raRef<CBitmapTexture> Texture
		{
			get
			{
				if (_texture == null)
				{
					_texture = (raRef<CBitmapTexture>) CR2WTypeManager.Create("raRef:CBitmapTexture", "texture", cr2w, this);
				}
				return _texture;
			}
			set
			{
				if (_texture == value)
				{
					return;
				}
				_texture = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("dynamicTexture")] 
		public raRef<DynamicTexture> DynamicTexture
		{
			get
			{
				if (_dynamicTexture == null)
				{
					_dynamicTexture = (raRef<DynamicTexture>) CR2WTypeManager.Create("raRef:DynamicTexture", "dynamicTexture", cr2w, this);
				}
				return _dynamicTexture;
			}
			set
			{
				if (_dynamicTexture == value)
				{
					return;
				}
				_dynamicTexture = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("parts")] 
		public CArray<inkTextureAtlasMapper> Parts
		{
			get
			{
				if (_parts == null)
				{
					_parts = (CArray<inkTextureAtlasMapper>) CR2WTypeManager.Create("array:inkTextureAtlasMapper", "parts", cr2w, this);
				}
				return _parts;
			}
			set
			{
				if (_parts == value)
				{
					return;
				}
				_parts = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("slices")] 
		public CArray<inkTextureAtlasSlice> Slices
		{
			get
			{
				if (_slices == null)
				{
					_slices = (CArray<inkTextureAtlasSlice>) CR2WTypeManager.Create("array:inkTextureAtlasSlice", "slices", cr2w, this);
				}
				return _slices;
			}
			set
			{
				if (_slices == value)
				{
					return;
				}
				_slices = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("slots", 3)] 
		public CArrayFixedSize<inkTextureSlot> Slots
		{
			get
			{
				if (_slots == null)
				{
					_slots = (CArrayFixedSize<inkTextureSlot>) CR2WTypeManager.Create("[3]inkTextureSlot", "slots", cr2w, this);
				}
				return _slots;
			}
			set
			{
				if (_slots == value)
				{
					return;
				}
				_slots = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("dynamicTextureSlot")] 
		public inkDynamicTextureSlot DynamicTextureSlot
		{
			get
			{
				if (_dynamicTextureSlot == null)
				{
					_dynamicTextureSlot = (inkDynamicTextureSlot) CR2WTypeManager.Create("inkDynamicTextureSlot", "dynamicTextureSlot", cr2w, this);
				}
				return _dynamicTextureSlot;
			}
			set
			{
				if (_dynamicTextureSlot == value)
				{
					return;
				}
				_dynamicTextureSlot = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("isSingleTextureMode")] 
		public CBool IsSingleTextureMode
		{
			get
			{
				if (_isSingleTextureMode == null)
				{
					_isSingleTextureMode = (CBool) CR2WTypeManager.Create("Bool", "isSingleTextureMode", cr2w, this);
				}
				return _isSingleTextureMode;
			}
			set
			{
				if (_isSingleTextureMode == value)
				{
					return;
				}
				_isSingleTextureMode = value;
				PropertySet(this);
			}
		}

		public inkTextureAtlas(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
