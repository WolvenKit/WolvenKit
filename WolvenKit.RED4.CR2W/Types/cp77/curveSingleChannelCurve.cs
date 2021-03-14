using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class curveSingleChannelCurve : CVariable
	{
		private CEnum<curveEInterpolationType> _interpolationType;
		private CEnum<curveESegmentsLinkType> _linkType;
		private DataBuffer _data;

		[Ordinal(0)] 
		[RED("interpolationType")] 
		public CEnum<curveEInterpolationType> InterpolationType
		{
			get
			{
				if (_interpolationType == null)
				{
					_interpolationType = (CEnum<curveEInterpolationType>) CR2WTypeManager.Create("curveEInterpolationType", "interpolationType", cr2w, this);
				}
				return _interpolationType;
			}
			set
			{
				if (_interpolationType == value)
				{
					return;
				}
				_interpolationType = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("linkType")] 
		public CEnum<curveESegmentsLinkType> LinkType
		{
			get
			{
				if (_linkType == null)
				{
					_linkType = (CEnum<curveESegmentsLinkType>) CR2WTypeManager.Create("curveESegmentsLinkType", "linkType", cr2w, this);
				}
				return _linkType;
			}
			set
			{
				if (_linkType == value)
				{
					return;
				}
				_linkType = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("data")] 
		public DataBuffer Data
		{
			get
			{
				if (_data == null)
				{
					_data = (DataBuffer) CR2WTypeManager.Create("DataBuffer", "data", cr2w, this);
				}
				return _data;
			}
			set
			{
				if (_data == value)
				{
					return;
				}
				_data = value;
				PropertySet(this);
			}
		}

		public curveSingleChannelCurve(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
