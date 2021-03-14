using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entGarmentParameterChunkData : CVariable
	{
		private CArray<CUInt8> _morphOffsetScales;
		private CArray<CUInt16> _visibleTriangleInds;

		[Ordinal(0)] 
		[RED("morphOffsetScales")] 
		public CArray<CUInt8> MorphOffsetScales
		{
			get
			{
				if (_morphOffsetScales == null)
				{
					_morphOffsetScales = (CArray<CUInt8>) CR2WTypeManager.Create("array:Uint8", "morphOffsetScales", cr2w, this);
				}
				return _morphOffsetScales;
			}
			set
			{
				if (_morphOffsetScales == value)
				{
					return;
				}
				_morphOffsetScales = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("visibleTriangleInds")] 
		public CArray<CUInt16> VisibleTriangleInds
		{
			get
			{
				if (_visibleTriangleInds == null)
				{
					_visibleTriangleInds = (CArray<CUInt16>) CR2WTypeManager.Create("array:Uint16", "visibleTriangleInds", cr2w, this);
				}
				return _visibleTriangleInds;
			}
			set
			{
				if (_visibleTriangleInds == value)
				{
					return;
				}
				_visibleTriangleInds = value;
				PropertySet(this);
			}
		}

		public entGarmentParameterChunkData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
