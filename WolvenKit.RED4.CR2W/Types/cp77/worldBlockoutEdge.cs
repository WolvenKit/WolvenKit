using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldBlockoutEdge : CVariable
	{
		private CArrayFixedSize<CUInt32> _points;
		private CArrayFixedSize<CUInt32> _areas;
		private CBool _isFree;

		[Ordinal(0)] 
		[RED("points", 2)] 
		public CArrayFixedSize<CUInt32> Points
		{
			get
			{
				if (_points == null)
				{
					_points = (CArrayFixedSize<CUInt32>) CR2WTypeManager.Create("[2]Uint32", "points", cr2w, this);
				}
				return _points;
			}
			set
			{
				if (_points == value)
				{
					return;
				}
				_points = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("areas", 2)] 
		public CArrayFixedSize<CUInt32> Areas
		{
			get
			{
				if (_areas == null)
				{
					_areas = (CArrayFixedSize<CUInt32>) CR2WTypeManager.Create("[2]Uint32", "areas", cr2w, this);
				}
				return _areas;
			}
			set
			{
				if (_areas == value)
				{
					return;
				}
				_areas = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("isFree")] 
		public CBool IsFree
		{
			get
			{
				if (_isFree == null)
				{
					_isFree = (CBool) CR2WTypeManager.Create("Bool", "isFree", cr2w, this);
				}
				return _isFree;
			}
			set
			{
				if (_isFree == value)
				{
					return;
				}
				_isFree = value;
				PropertySet(this);
			}
		}

		public worldBlockoutEdge(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
