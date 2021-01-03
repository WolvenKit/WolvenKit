using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameuiPhoneWaveformData : IScriptable
	{
		[Ordinal(0)]  [RED("points")] public CArray<Vector4> Points { get; set; }

		public gameuiPhoneWaveformData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
