using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ChestPress : InteractiveDevice
	{
		private CHandle<AnimFeature_ChestPress> _animFeatureData;
		private CName _animFeatureDataName;

		[Ordinal(93)] 
		[RED("animFeatureData")] 
		public CHandle<AnimFeature_ChestPress> AnimFeatureData
		{
			get
			{
				if (_animFeatureData == null)
				{
					_animFeatureData = (CHandle<AnimFeature_ChestPress>) CR2WTypeManager.Create("handle:AnimFeature_ChestPress", "animFeatureData", cr2w, this);
				}
				return _animFeatureData;
			}
			set
			{
				if (_animFeatureData == value)
				{
					return;
				}
				_animFeatureData = value;
				PropertySet(this);
			}
		}

		[Ordinal(94)] 
		[RED("animFeatureDataName")] 
		public CName AnimFeatureDataName
		{
			get
			{
				if (_animFeatureDataName == null)
				{
					_animFeatureDataName = (CName) CR2WTypeManager.Create("CName", "animFeatureDataName", cr2w, this);
				}
				return _animFeatureDataName;
			}
			set
			{
				if (_animFeatureDataName == value)
				{
					return;
				}
				_animFeatureDataName = value;
				PropertySet(this);
			}
		}

		public ChestPress(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
