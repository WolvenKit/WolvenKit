using CP77.CR2W.Reflection;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gsmStateObserver_RichPresence : gsmIStateObserver
	{
		public gsmStateObserver_RichPresence(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
