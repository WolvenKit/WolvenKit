using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class OdaCementBagControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(103)] [RED("cementEffectCooldown")] public CFloat CementEffectCooldown { get; set; }

		public OdaCementBagControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
