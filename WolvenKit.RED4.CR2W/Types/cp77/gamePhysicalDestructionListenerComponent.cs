using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamePhysicalDestructionListenerComponent : entIComponent
	{
		private CName _physicalDestructionComponentName;
		private CArray<CFloat> _thresholdLevels;

		[Ordinal(3)] 
		[RED("physicalDestructionComponentName")] 
		public CName PhysicalDestructionComponentName
		{
			get
			{
				if (_physicalDestructionComponentName == null)
				{
					_physicalDestructionComponentName = (CName) CR2WTypeManager.Create("CName", "physicalDestructionComponentName", cr2w, this);
				}
				return _physicalDestructionComponentName;
			}
			set
			{
				if (_physicalDestructionComponentName == value)
				{
					return;
				}
				_physicalDestructionComponentName = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("thresholdLevels")] 
		public CArray<CFloat> ThresholdLevels
		{
			get
			{
				if (_thresholdLevels == null)
				{
					_thresholdLevels = (CArray<CFloat>) CR2WTypeManager.Create("array:Float", "thresholdLevels", cr2w, this);
				}
				return _thresholdLevels;
			}
			set
			{
				if (_thresholdLevels == value)
				{
					return;
				}
				_thresholdLevels = value;
				PropertySet(this);
			}
		}

		public gamePhysicalDestructionListenerComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
