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
			get => GetProperty(ref _feature);
			set => SetProperty(ref _feature, value);
		}

		public ApplyDroneProceduralAnimFeatureEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
