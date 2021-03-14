using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectObjectFilter_BlockingGeometry : gameEffectObjectGroupFilter
	{
		private CBool _inclusive;
		private CBool _sortQueryResultsByDistance;

		[Ordinal(0)] 
		[RED("inclusive")] 
		public CBool Inclusive
		{
			get
			{
				if (_inclusive == null)
				{
					_inclusive = (CBool) CR2WTypeManager.Create("Bool", "inclusive", cr2w, this);
				}
				return _inclusive;
			}
			set
			{
				if (_inclusive == value)
				{
					return;
				}
				_inclusive = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("sortQueryResultsByDistance")] 
		public CBool SortQueryResultsByDistance
		{
			get
			{
				if (_sortQueryResultsByDistance == null)
				{
					_sortQueryResultsByDistance = (CBool) CR2WTypeManager.Create("Bool", "sortQueryResultsByDistance", cr2w, this);
				}
				return _sortQueryResultsByDistance;
			}
			set
			{
				if (_sortQueryResultsByDistance == value)
				{
					return;
				}
				_sortQueryResultsByDistance = value;
				PropertySet(this);
			}
		}

		public gameEffectObjectFilter_BlockingGeometry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
