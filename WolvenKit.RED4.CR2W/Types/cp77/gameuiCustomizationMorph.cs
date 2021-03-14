using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiCustomizationMorph : gameuiCensorshipInfo
	{
		private CName _regionName;
		private CName _targetName;

		[Ordinal(2)] 
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

		[Ordinal(3)] 
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

		public gameuiCustomizationMorph(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
