using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ReserveItemToThisDropPoint : ScriptableDeviceAction
	{
		[Ordinal(0)]  [RED("item")] public TweakDBID Item { get; set; }

		public ReserveItemToThisDropPoint(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
