using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GlitchedTurret : Device
	{
		[Ordinal(86)] [RED("animFeature")] public CHandle<AnimFeature_SensorDevice> AnimFeature { get; set; }

		public GlitchedTurret(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
