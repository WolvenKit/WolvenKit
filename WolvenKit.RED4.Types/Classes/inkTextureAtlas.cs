using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkTextureAtlas : CResource
	{
		private CEnum<inkTextureType> _activeTexture;
		private CEnum<inkETextureResolution> _textureResolution;
		private CResourceAsyncReference<CBitmapTexture> _texture;
		private CResourceAsyncReference<DynamicTexture> _dynamicTexture;
		private CArray<inkTextureAtlasMapper> _parts;
		private CArray<inkTextureAtlasSlice> _slices;
		private CArrayFixedSize<inkTextureSlot> _slots;
		private inkDynamicTextureSlot _dynamicTextureSlot;
		private CBool _isSingleTextureMode;

		[Ordinal(1)] 
		[RED("activeTexture")] 
		public CEnum<inkTextureType> ActiveTexture
		{
			get => GetProperty(ref _activeTexture);
			set => SetProperty(ref _activeTexture, value);
		}

		[Ordinal(2)] 
		[RED("textureResolution")] 
		public CEnum<inkETextureResolution> TextureResolution
		{
			get => GetProperty(ref _textureResolution);
			set => SetProperty(ref _textureResolution, value);
		}

		[Ordinal(3)] 
		[RED("texture")] 
		public CResourceAsyncReference<CBitmapTexture> Texture
		{
			get => GetProperty(ref _texture);
			set => SetProperty(ref _texture, value);
		}

		[Ordinal(4)] 
		[RED("dynamicTexture")] 
		public CResourceAsyncReference<DynamicTexture> DynamicTexture
		{
			get => GetProperty(ref _dynamicTexture);
			set => SetProperty(ref _dynamicTexture, value);
		}

		[Ordinal(5)] 
		[RED("parts")] 
		public CArray<inkTextureAtlasMapper> Parts
		{
			get => GetProperty(ref _parts);
			set => SetProperty(ref _parts, value);
		}

		[Ordinal(6)] 
		[RED("slices")] 
		public CArray<inkTextureAtlasSlice> Slices
		{
			get => GetProperty(ref _slices);
			set => SetProperty(ref _slices, value);
		}

		[Ordinal(7)] 
		[RED("slots", 3)] 
		public CArrayFixedSize<inkTextureSlot> Slots
		{
			get => GetProperty(ref _slots);
			set => SetProperty(ref _slots, value);
		}

		[Ordinal(8)] 
		[RED("dynamicTextureSlot")] 
		public inkDynamicTextureSlot DynamicTextureSlot
		{
			get => GetProperty(ref _dynamicTextureSlot);
			set => SetProperty(ref _dynamicTextureSlot, value);
		}

		[Ordinal(9)] 
		[RED("isSingleTextureMode")] 
		public CBool IsSingleTextureMode
		{
			get => GetProperty(ref _isSingleTextureMode);
			set => SetProperty(ref _isSingleTextureMode, value);
		}
	}
}
