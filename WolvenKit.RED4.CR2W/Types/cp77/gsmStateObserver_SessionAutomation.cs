using WolvenKit.RED4.CR2W.Reflection;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gsmStateObserver_SessionAutomation : gsmIStateObserver
	{

		public gsmStateObserver_SessionAutomation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
