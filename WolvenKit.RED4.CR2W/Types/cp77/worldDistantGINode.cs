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
			get
			{
				if (_dataAlbedo == null)
				{
					_dataAlbedo = (raRef<CBitmapTexture>) CR2WTypeManager.Create("raRef:CBitmapTexture", "dataAlbedo", cr2w, this);
				}
				return _dataAlbedo;
			}
			set
			{
				if (_dataAlbedo == value)
				{
					return;
				}
				_dataAlbedo = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("dataNormal")] 
		public raRef<CBitmapTexture> DataNormal
		{
			get
			{
				if (_dataNormal == null)
				{
					_dataNormal = (raRef<CBitmapTexture>) CR2WTypeManager.Create("raRef:CBitmapTexture", "dataNormal", cr2w, this);
				}
				return _dataNormal;
			}
			set
			{
				if (_dataNormal == value)
				{
					return;
				}
				_dataNormal = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("dataHeight")] 
		public raRef<CBitmapTexture> DataHeight
		{
			get
			{
				if (_dataHeight == null)
				{
					_dataHeight = (raRef<CBitmapTexture>) CR2WTypeManager.Create("raRef:CBitmapTexture", "dataHeight", cr2w, this);
				}
				return _dataHeight;
			}
			set
			{
				if (_dataHeight == value)
				{
					return;
				}
				_dataHeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("sectorSpan")] 
		public Vector4 SectorSpan
		{
			get
			{
				if (_sectorSpan == null)
				{
					_sectorSpan = (Vector4) CR2WTypeManager.Create("Vector4", "sectorSpan", cr2w, this);
				}
				return _sectorSpan;
			}
			set
			{
				if (_sectorSpan == value)
				{
					return;
				}
				_sectorSpan = value;
				PropertySet(this);
			}
		}

		public worldDistantGINode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
