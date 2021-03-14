using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldRaceSplineNode : worldSpeedSplineNode
	{
		private CArray<worldRaceSplineNodeOffset> _offsets;
		private CFloat _offsetDefault;

		[Ordinal(17)] 
		[RED("offsets")] 
		public CArray<worldRaceSplineNodeOffset> Offsets
		{
			get
			{
				if (_offsets == null)
				{
					_offsets = (CArray<worldRaceSplineNodeOffset>) CR2WTypeManager.Create("array:worldRaceSplineNodeOffset", "offsets", cr2w, this);
				}
				return _offsets;
			}
			set
			{
				if (_offsets == value)
				{
					return;
				}
				_offsets = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("offsetDefault")] 
		public CFloat OffsetDefault
		{
			get
			{
				if (_offsetDefault == null)
				{
					_offsetDefault = (CFloat) CR2WTypeManager.Create("Float", "offsetDefault", cr2w, this);
				}
				return _offsetDefault;
			}
			set
			{
				if (_offsetDefault == value)
				{
					return;
				}
				_offsetDefault = value;
				PropertySet(this);
			}
		}

		public worldRaceSplineNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
