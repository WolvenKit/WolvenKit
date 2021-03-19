using WolvenKit.RED4.CR2W.Reflection;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class C4Controller : ExplosiveDeviceController
	{

		public C4Controller(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
