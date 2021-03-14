using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldHeatmapSetup : CVariable
	{
		private Box _volumeBox;
		private CUInt32 _verticalResolution;
		private CUInt32 _horizontalResolution;

		[Ordinal(0)] 
		[RED("volumeBox")] 
		public Box VolumeBox
		{
			get
			{
				if (_volumeBox == null)
				{
					_volumeBox = (Box) CR2WTypeManager.Create("Box", "volumeBox", cr2w, this);
				}
				return _volumeBox;
			}
			set
			{
				if (_volumeBox == value)
				{
					return;
				}
				_volumeBox = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("verticalResolution")] 
		public CUInt32 VerticalResolution
		{
			get
			{
				if (_verticalResolution == null)
				{
					_verticalResolution = (CUInt32) CR2WTypeManager.Create("Uint32", "verticalResolution", cr2w, this);
				}
				return _verticalResolution;
			}
			set
			{
				if (_verticalResolution == value)
				{
					return;
				}
				_verticalResolution = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("horizontalResolution")] 
		public CUInt32 HorizontalResolution
		{
			get
			{
				if (_horizontalResolution == null)
				{
					_horizontalResolution = (CUInt32) CR2WTypeManager.Create("Uint32", "horizontalResolution", cr2w, this);
				}
				return _horizontalResolution;
			}
			set
			{
				if (_horizontalResolution == value)
				{
					return;
				}
				_horizontalResolution = value;
				PropertySet(this);
			}
		}

		public worldHeatmapSetup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
