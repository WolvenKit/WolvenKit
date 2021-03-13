using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ForkliftControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(103)] [RED("forkliftSetup")] public ForkliftSetup ForkliftSetup { get; set; }
		[Ordinal(104)] [RED("isUp")] public CBool IsUp { get; set; }

		public ForkliftControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
