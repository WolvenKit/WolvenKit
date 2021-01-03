using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SharpeningAreaSettings : IAreaSettings
	{
		[Ordinal(0)]  [RED("sharpeningStrength")] public CFloat SharpeningStrength { get; set; }

		public SharpeningAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
