using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldNavigationScriptCostModCircle : IScriptable
	{
		private Vector4 _pos;
		private CFloat _range;
		private CFloat _cost;

		[Ordinal(0)] 
		[RED("pos")] 
		public Vector4 Pos
		{
			get
			{
				if (_pos == null)
				{
					_pos = (Vector4) CR2WTypeManager.Create("Vector4", "pos", cr2w, this);
				}
				return _pos;
			}
			set
			{
				if (_pos == value)
				{
					return;
				}
				_pos = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("range")] 
		public CFloat Range
		{
			get
			{
				if (_range == null)
				{
					_range = (CFloat) CR2WTypeManager.Create("Float", "range", cr2w, this);
				}
				return _range;
			}
			set
			{
				if (_range == value)
				{
					return;
				}
				_range = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("cost")] 
		public CFloat Cost
		{
			get
			{
				if (_cost == null)
				{
					_cost = (CFloat) CR2WTypeManager.Create("Float", "cost", cr2w, this);
				}
				return _cost;
			}
			set
			{
				if (_cost == value)
				{
					return;
				}
				_cost = value;
				PropertySet(this);
			}
		}

		public worldNavigationScriptCostModCircle(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
