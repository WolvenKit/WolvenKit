using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldRaceSplineNodeOffset : CVariable
	{
		private CFloat _from;
		private CFloat _to;
		private CFloat _left;
		private CFloat _right;

		[Ordinal(0)] 
		[RED("from")] 
		public CFloat From
		{
			get
			{
				if (_from == null)
				{
					_from = (CFloat) CR2WTypeManager.Create("Float", "from", cr2w, this);
				}
				return _from;
			}
			set
			{
				if (_from == value)
				{
					return;
				}
				_from = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("to")] 
		public CFloat To
		{
			get
			{
				if (_to == null)
				{
					_to = (CFloat) CR2WTypeManager.Create("Float", "to", cr2w, this);
				}
				return _to;
			}
			set
			{
				if (_to == value)
				{
					return;
				}
				_to = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("left")] 
		public CFloat Left
		{
			get
			{
				if (_left == null)
				{
					_left = (CFloat) CR2WTypeManager.Create("Float", "left", cr2w, this);
				}
				return _left;
			}
			set
			{
				if (_left == value)
				{
					return;
				}
				_left = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("right")] 
		public CFloat Right
		{
			get
			{
				if (_right == null)
				{
					_right = (CFloat) CR2WTypeManager.Create("Float", "right", cr2w, this);
				}
				return _right;
			}
			set
			{
				if (_right == value)
				{
					return;
				}
				_right = value;
				PropertySet(this);
			}
		}

		public worldRaceSplineNodeOffset(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
