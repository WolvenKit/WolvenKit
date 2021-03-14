using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entMorphTargetWeightEntry : CVariable
	{
		private CName _targetName;
		private CName _regionName;
		private CFloat _weight;

		[Ordinal(0)] 
		[RED("targetName")] 
		public CName TargetName
		{
			get
			{
				if (_targetName == null)
				{
					_targetName = (CName) CR2WTypeManager.Create("CName", "targetName", cr2w, this);
				}
				return _targetName;
			}
			set
			{
				if (_targetName == value)
				{
					return;
				}
				_targetName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("regionName")] 
		public CName RegionName
		{
			get
			{
				if (_regionName == null)
				{
					_regionName = (CName) CR2WTypeManager.Create("CName", "regionName", cr2w, this);
				}
				return _regionName;
			}
			set
			{
				if (_regionName == value)
				{
					return;
				}
				_regionName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("weight")] 
		public CFloat Weight
		{
			get
			{
				if (_weight == null)
				{
					_weight = (CFloat) CR2WTypeManager.Create("Float", "weight", cr2w, this);
				}
				return _weight;
			}
			set
			{
				if (_weight == value)
				{
					return;
				}
				_weight = value;
				PropertySet(this);
			}
		}

		public entMorphTargetWeightEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
