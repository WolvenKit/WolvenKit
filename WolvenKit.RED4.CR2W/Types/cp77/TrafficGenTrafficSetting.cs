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
			get
			{
				if (_meshImpact == null)
				{
					_meshImpact = (CEnum<TrafficGenMeshImpact>) CR2WTypeManager.Create("TrafficGenMeshImpact", "meshImpact", cr2w, this);
				}
				return _meshImpact;
			}
			set
			{
				if (_meshImpact == value)
				{
					return;
				}
				_meshImpact = value;
				PropertySet(this);
			}
		}

		public TrafficGenTrafficSetting(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
