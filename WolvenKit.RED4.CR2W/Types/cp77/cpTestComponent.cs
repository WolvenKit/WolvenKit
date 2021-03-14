using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class cpTestComponent : gameComponent
	{
		[Ordinal(4)] [RED("whatever")] public CFloat Whatever { get; set; }
		[Ordinal(5)] [RED("whateverIE")] public CFloat WhateverIE { get; set; }

		public cpTestComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
