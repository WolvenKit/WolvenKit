using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SNameplateRangesData : CVariable
	{
		private CFloat _c_DisplayRange;
		private CFloat _c_MaxDisplayRange;
		private CFloat _c_MaxDisplayRangeNotAggressive;
		private CFloat _c_DisplayRangeNotAggressive;

		[Ordinal(0)] 
		[RED("c_DisplayRange")] 
		public CFloat C_DisplayRange
		{
			get
			{
				if (_c_DisplayRange == null)
				{
					_c_DisplayRange = (CFloat) CR2WTypeManager.Create("Float", "c_DisplayRange", cr2w, this);
				}
				return _c_DisplayRange;
			}
			set
			{
				if (_c_DisplayRange == value)
				{
					return;
				}
				_c_DisplayRange = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("c_MaxDisplayRange")] 
		public CFloat C_MaxDisplayRange
		{
			get
			{
				if (_c_MaxDisplayRange == null)
				{
					_c_MaxDisplayRange = (CFloat) CR2WTypeManager.Create("Float", "c_MaxDisplayRange", cr2w, this);
				}
				return _c_MaxDisplayRange;
			}
			set
			{
				if (_c_MaxDisplayRange == value)
				{
					return;
				}
				_c_MaxDisplayRange = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("c_MaxDisplayRangeNotAggressive")] 
		public CFloat C_MaxDisplayRangeNotAggressive
		{
			get
			{
				if (_c_MaxDisplayRangeNotAggressive == null)
				{
					_c_MaxDisplayRangeNotAggressive = (CFloat) CR2WTypeManager.Create("Float", "c_MaxDisplayRangeNotAggressive", cr2w, this);
				}
				return _c_MaxDisplayRangeNotAggressive;
			}
			set
			{
				if (_c_MaxDisplayRangeNotAggressive == value)
				{
					return;
				}
				_c_MaxDisplayRangeNotAggressive = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("c_DisplayRangeNotAggressive")] 
		public CFloat C_DisplayRangeNotAggressive
		{
			get
			{
				if (_c_DisplayRangeNotAggressive == null)
				{
					_c_DisplayRangeNotAggressive = (CFloat) CR2WTypeManager.Create("Float", "c_DisplayRangeNotAggressive", cr2w, this);
				}
				return _c_DisplayRangeNotAggressive;
			}
			set
			{
				if (_c_DisplayRangeNotAggressive == value)
				{
					return;
				}
				_c_DisplayRangeNotAggressive = value;
				PropertySet(this);
			}
		}

		public SNameplateRangesData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
