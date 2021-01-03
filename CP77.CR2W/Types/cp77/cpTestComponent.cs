using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class cpTestComponent : gameComponent
	{
		[Ordinal(0)]  [RED("whatever")] public CFloat Whatever { get; set; }
		[Ordinal(1)]  [RED("whateverIE")] public CFloat WhateverIE { get; set; }

		public cpTestComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
