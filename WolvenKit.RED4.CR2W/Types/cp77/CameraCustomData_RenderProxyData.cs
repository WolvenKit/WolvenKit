using WolvenKit.RED4.CR2W.Reflection;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CameraCustomData_RenderProxyData : ICameraStorageCustomData
	{
		public CameraCustomData_RenderProxyData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
