using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldDistantGINode : worldNode
	{
		private raRef<CBitmapTexture> _dataAlbedo;
		private raRef<CBitmapTexture> _dataNormal;
		private raRef<CBitmapTexture> _dataHeight;
		private Vector4 _sectorSpan;

		[Ordinal(4)] 
		[RED("dataAlbedo")] 
		public raRef<CBitmapTexture> DataAlbedo
		{
			get => GetProperty(ref _dataAlbedo);
			set => SetProperty(ref _dataAlbedo, value);
		}

		[Ordinal(5)] 
		[RED("dataNormal")] 
		public raRef<CBitmapTexture> DataNormal
		{
			get => GetProperty(ref _dataNormal);
			set => SetProperty(ref _dataNormal, value);
		}

		[Ordinal(6)] 
		[RED("dataHeight")] 
		public raRef<CBitmapTexture> DataHeight
		{
			get => GetProperty(ref _dataHeight);
			set => SetProperty(ref _dataHeight, value);
		}

		[Ordinal(7)] 
		[RED("sectorSpan")] 
		public Vector4 SectorSpan
		{
			get => GetProperty(ref _sectorSpan);
			set => SetProperty(ref _sectorSpan, value);
		}

		public worldDistantGINode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
