using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectFilter_NotObstructed : gameEffectObjectSingleFilter
	{
		private CFloat _forwardOffset;
		private CHandle<physicsFilterData> _filterData;

		[Ordinal(0)] 
		[RED("forwardOffset")] 
		public CFloat ForwardOffset
		{
			get
			{
				if (_forwardOffset == null)
				{
					_forwardOffset = (CFloat) CR2WTypeManager.Create("Float", "forwardOffset", cr2w, this);
				}
				return _forwardOffset;
			}
			set
			{
				if (_forwardOffset == value)
				{
					return;
				}
				_forwardOffset = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("filterData")] 
		public CHandle<physicsFilterData> FilterData
		{
			get
			{
				if (_filterData == null)
				{
					_filterData = (CHandle<physicsFilterData>) CR2WTypeManager.Create("handle:physicsFilterData", "filterData", cr2w, this);
				}
				return _filterData;
			}
			set
			{
				if (_filterData == value)
				{
					return;
				}
				_filterData = value;
				PropertySet(this);
			}
		}

		public gameEffectFilter_NotObstructed(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
