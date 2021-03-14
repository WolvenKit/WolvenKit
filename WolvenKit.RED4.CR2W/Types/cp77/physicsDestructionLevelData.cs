using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class physicsDestructionLevelData : CVariable
	{
		private CHandle<physicsFilterData> _filterData;
		private raRef<worldEffect> _fracturingEffect;

		[Ordinal(0)] 
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

		[Ordinal(1)] 
		[RED("fracturingEffect")] 
		public raRef<worldEffect> FracturingEffect
		{
			get
			{
				if (_fracturingEffect == null)
				{
					_fracturingEffect = (raRef<worldEffect>) CR2WTypeManager.Create("raRef:worldEffect", "fracturingEffect", cr2w, this);
				}
				return _fracturingEffect;
			}
			set
			{
				if (_fracturingEffect == value)
				{
					return;
				}
				_fracturingEffect = value;
				PropertySet(this);
			}
		}

		public physicsDestructionLevelData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
