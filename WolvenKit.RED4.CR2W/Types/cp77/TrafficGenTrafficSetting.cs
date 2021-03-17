using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TrafficGenTrafficSetting : CVariable
	{
		private CEnum<TrafficGenMeshImpact> _meshImpact;

		[Ordinal(0)] 
		[RED("meshImpact")] 
		public CEnum<TrafficGenMeshImpact> MeshImpact
		{
			get => GetProperty(ref _meshImpact);
			set => SetProperty(ref _meshImpact, value);
		}

		public TrafficGenTrafficSetting(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
