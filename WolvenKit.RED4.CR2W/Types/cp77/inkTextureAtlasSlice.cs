using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkTextureAtlasSlice : CVariable
	{
		private CName _partName;
		private RectF _nineSliceScaleRect;

		[Ordinal(0)] 
		[RED("partName")] 
		public CName PartName
		{
			get
			{
				if (_partName == null)
				{
					_partName = (CName) CR2WTypeManager.Create("CName", "partName", cr2w, this);
				}
				return _partName;
			}
			set
			{
				if (_partName == value)
				{
					return;
				}
				_partName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("nineSliceScaleRect")] 
		public RectF NineSliceScaleRect
		{
			get
			{
				if (_nineSliceScaleRect == null)
				{
					_nineSliceScaleRect = (RectF) CR2WTypeManager.Create("RectF", "nineSliceScaleRect", cr2w, this);
				}
				return _nineSliceScaleRect;
			}
			set
			{
				if (_nineSliceScaleRect == value)
				{
					return;
				}
				_nineSliceScaleRect = value;
				PropertySet(this);
			}
		}

		public inkTextureAtlasSlice(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
