using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkCircleWidget : inkBaseShapeWidget
	{
		private CUInt32 _segmentsNumber;

		[Ordinal(20)] 
		[RED("segmentsNumber")] 
		public CUInt32 SegmentsNumber
		{
			get
			{
				if (_segmentsNumber == null)
				{
					_segmentsNumber = (CUInt32) CR2WTypeManager.Create("Uint32", "segmentsNumber", cr2w, this);
				}
				return _segmentsNumber;
			}
			set
			{
				if (_segmentsNumber == value)
				{
					return;
				}
				_segmentsNumber = value;
				PropertySet(this);
			}
		}

		public inkCircleWidget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
