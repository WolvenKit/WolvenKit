using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameNetrunnerPrototypeSpawnRequestEvent : redEvent
	{
		private CName _whatToSpawn;
		private Vector3 _whereToSpawn;
		private Vector3 _scale;
		private CUInt8 _colorIndex;

		[Ordinal(0)] 
		[RED("whatToSpawn")] 
		public CName WhatToSpawn
		{
			get => GetProperty(ref _whatToSpawn);
			set => SetProperty(ref _whatToSpawn, value);
		}

		[Ordinal(1)] 
		[RED("whereToSpawn")] 
		public Vector3 WhereToSpawn
		{
			get => GetProperty(ref _whereToSpawn);
			set => SetProperty(ref _whereToSpawn, value);
		}

		[Ordinal(2)] 
		[RED("scale")] 
		public Vector3 Scale
		{
			get => GetProperty(ref _scale);
			set => SetProperty(ref _scale, value);
		}

		[Ordinal(3)] 
		[RED("colorIndex")] 
		public CUInt8 ColorIndex
		{
			get => GetProperty(ref _colorIndex);
			set => SetProperty(ref _colorIndex, value);
		}

		public gameNetrunnerPrototypeSpawnRequestEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
