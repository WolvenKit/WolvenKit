using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ApplyDroneProceduralAnimFeatureEvent : redEvent
	{
		private CHandle<AnimFeature_DroneProcedural> _feature;

		[Ordinal(0)] 
		[RED("feature")] 
		public CHandle<AnimFeature_DroneProcedural> Feature
		{
			get
			{
				if (_feature == null)
				{
					_feature = (CHandle<AnimFeature_DroneProcedural>) CR2WTypeManager.Create("handle:AnimFeature_DroneProcedural", "feature", cr2w, this);
				}
				return _feature;
			}
			set
			{
				if (_feature == value)
				{
					return;
				}
				_feature = value;
				PropertySet(this);
			}
		}

		public ApplyDroneProceduralAnimFeatureEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
