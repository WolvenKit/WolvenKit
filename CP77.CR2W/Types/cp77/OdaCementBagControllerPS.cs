using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class OdaCementBagControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(0)]  [RED("cementEffectCooldown")] public CFloat CementEffectCooldown { get; set; }

		public OdaCementBagControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
