using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameNetrunnerPrototypeSpawnRequestEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("whatToSpawn")] 
		public CName WhatToSpawn
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("whereToSpawn")] 
		public Vector3 WhereToSpawn
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(2)] 
		[RED("scale")] 
		public Vector3 Scale
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(3)] 
		[RED("colorIndex")] 
		public CUInt8 ColorIndex
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		public gameNetrunnerPrototypeSpawnRequestEvent()
		{
			WhereToSpawn = new Vector3();
			Scale = new Vector3();
			ColorIndex = 255;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
