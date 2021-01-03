using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameNetrunnerPrototypeSpawnRequestEvent : redEvent
	{
		[Ordinal(0)]  [RED("colorIndex")] public CUInt8 ColorIndex { get; set; }
		[Ordinal(1)]  [RED("scale")] public Vector3 Scale { get; set; }
		[Ordinal(2)]  [RED("whatToSpawn")] public CName WhatToSpawn { get; set; }
		[Ordinal(3)]  [RED("whereToSpawn")] public Vector3 WhereToSpawn { get; set; }

		public gameNetrunnerPrototypeSpawnRequestEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
