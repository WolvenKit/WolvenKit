using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class InputDeviceController : gameScriptableComponent
	{
		[Ordinal(5)] [RED("isStarted")] public CBool IsStarted { get; set; }

		public InputDeviceController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
